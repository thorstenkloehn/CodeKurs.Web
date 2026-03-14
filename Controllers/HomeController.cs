using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Models;
using CodeKurs.Web.Services;
using CodeKurs.Web.Data;

namespace CodeKurs.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CodeExecutorService _codeExecutor;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, CodeExecutorService codeExecutor, ApplicationDbContext context)
    {
        _logger = logger;
        _codeExecutor = codeExecutor;
        _context = context;
    }

    public async Task<IActionResult> Index(int? id, string? language)
    {
        ProgrammingTask? task = null;

        if (id.HasValue) 
        {
            task = await _context.Tasks.Include(t => t.Lesson).FirstOrDefaultAsync(t => t.Id == id.Value);
        }
        else if (!string.IsNullOrEmpty(language))
        {
            task = await _context.Tasks.Include(t => t.Lesson)
                .Where(t => t.Language == language)
                .OrderBy(t => t.LessonId).ThenBy(t => t.Order)
                .FirstOrDefaultAsync();
        }
        else
        {
            task = await _context.Tasks.Include(t => t.Lesson)
                .OrderBy(t => t.LessonId).ThenBy(t => t.Order)
                .FirstOrDefaultAsync();
        }

        if (task == null)
        {
            return RedirectToAction("CourseSelection");
        }

        // Filter: Nur Lektionen der GLEICHEN Sprache wie die aktuelle Aufgabe laden
        ViewBag.Lessons = await _context.Lessons
            .Include(l => l.Tasks)
            .Where(l => l.Language == task.Language)
            .OrderBy(l => l.Order)
            .ToListAsync();
        
        ViewBag.CurrentLanguage = task.Language;
        
        // Fortschritt laden
        var progress = await _context.Progress
            .FirstOrDefaultAsync(p => p.TaskId == task.Id && p.UserId == "guest");
        
        if (progress != null && !string.IsNullOrEmpty(progress.LastSubmittedCode))
        {
            task.InitialCode = progress.LastSubmittedCode;
            ViewBag.IsCompleted = progress.IsCompleted;
        }
        else if (!string.IsNullOrEmpty(task.PlaceholderDependency))
        {
            if (int.TryParse(task.PlaceholderDependency, out int prevTaskId))
            {
                var prevProgress = await _context.Progress
                    .FirstOrDefaultAsync(p => p.TaskId == prevTaskId && p.UserId == "guest");
                
                if (prevProgress != null && !string.IsNullOrEmpty(prevProgress.LastSubmittedCode))
                {
                    task.InitialCode = prevProgress.LastSubmittedCode;
                }
            }
        }

        return View(task);
    }

    public async Task<IActionResult> CourseSelection()
    {
        var languages = await _context.Lessons
            .Select(l => l.Language)
            .Distinct()
            .ToListAsync();
            
        return View(languages);
    }

    [HttpPost]
    public async Task<IActionResult> RunCode([FromBody] CodeRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Code))
        {
            return Json(new { error = "Kein Inhalt empfangen.", success = false });
        }

        try
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == (request.TaskId ?? 0));
            if (task == null) return Json(new { error = "Aufgabe nicht gefunden.", success = false });

            string output = "";
            bool validated = false;
            object? errors = null;

            if (task.Type == TaskType.Programming || task.Type == TaskType.Edu || task.Type == TaskType.Output)
            {
                if (!string.IsNullOrEmpty(task.RequiredKeywords))
                {
                    var missing = task.RequiredKeywords.Split(',')
                        .Select(k => k.Trim())
                        .Where(k => !request.Code.Contains(k))
                        .ToList();
                    
                    if (missing.Any())
                    {
                        return Json(new { 
                            error = $"Pflicht-Schlüsselwörter fehlen: {string.Join(", ", missing)}", 
                            success = true, 
                            validated = false,
                            type = task.Type.ToString() 
                        });
                    }
                }

                string codeToExecute = request.Code;
                if (task.Type == TaskType.Edu && !string.IsNullOrEmpty(task.TestCode))
                {
                    codeToExecute = $"{request.Code}\n\n{task.TestCode}";
                }

                var execResult = await _codeExecutor.ExecuteAsync(codeToExecute, task.Language);
                output = execResult.Output;
                errors = execResult.Errors;

                if (task.Type == TaskType.Edu)
                {
                    validated = output.Contains("SUCCESS_ALL_TESTS_PASSED") && !output.Contains("Laufzeitfehler");
                }
                else
                {
                    validated = output.Trim().Equals(task.ExpectedOutput.Trim(), StringComparison.OrdinalIgnoreCase);
                }
            }
            else if (task.Type == TaskType.MultipleChoice)
            {
                validated = request.Code.Trim().Equals(task.CorrectAnswer?.Trim(), StringComparison.OrdinalIgnoreCase);
                output = validated ? "Richtig!" : "Leider falsch.";
            }
            else if (task.Type == TaskType.Theory)
            {
                validated = true;
                output = "Lektion abgeschlossen!";
            }

            var progress = await _context.Progress
                .FirstOrDefaultAsync(p => p.TaskId == task.Id && p.UserId == "guest");
            
            if (progress == null)
            {
                progress = new UserProgress
                {
                    TaskId = task.Id,
                    UserId = "guest",
                    LastSubmittedCode = request.Code ?? string.Empty,
                    IsCompleted = validated,
                    LastUpdated = DateTime.UtcNow
                };
                _context.Progress.Add(progress);
            }
            else
            {
                progress.LastSubmittedCode = request.Code ?? string.Empty;
                if (validated) progress.IsCompleted = true;
                progress.LastUpdated = DateTime.UtcNow;
            }
            
            await _context.SaveChangesAsync();

            return Json(new { output, success = true, validated, type = task.Type.ToString(), errors });
        }
        catch (Exception ex)
        {
            return Json(new { error = $"Fehler: {ex.Message}", success = false });
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class CodeRequest
{
    public string? Code { get; set; }
    public int? TaskId { get; set; }
}
