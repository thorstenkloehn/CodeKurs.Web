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

    public async Task<IActionResult> Index(int? id)
    {
        // Wenn keine ID übergeben wurde, nimm die erste Aufgabe
        var task = id.HasValue 
            ? await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id.Value)
            : await _context.Tasks.FirstOrDefaultAsync();

        if (task == null)
        {
            return NotFound("Aufgabe nicht gefunden.");
        }

        // Alle Aufgaben gruppiert nach Sprache für die Navigation laden
        ViewBag.GroupedTasks = await _context.Tasks
            .GroupBy(t => t.Language)
            .ToDictionaryAsync(g => g.Key, g => g.Select(t => new TaskNavItem { Id = t.Id, Title = t.Title, Type = t.Type }).ToList());
        
        // Fortschritt laden
        var progress = await _context.Progress
            .FirstOrDefaultAsync(p => p.TaskId == task.Id && p.UserId == "guest");
        
        if (progress != null && !string.IsNullOrEmpty(progress.LastSubmittedCode))
        {
            task.InitialCode = progress.LastSubmittedCode;
            ViewBag.IsCompleted = progress.IsCompleted;
        }

        return View(task);
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

            if (task.Type == TaskType.Programming)
            {
                // Keyword-Prüfung
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

                var execResult = await _codeExecutor.ExecuteAsync(request.Code, task.Language);
                output = execResult.Output;
                errors = execResult.Errors;
                validated = output.Trim().Equals(task.ExpectedOutput.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            else if (task.Type == TaskType.MultipleChoice)
            {
                validated = request.Code.Trim().Equals(task.CorrectAnswer?.Trim(), StringComparison.OrdinalIgnoreCase);
                output = validated ? "Richtig!" : "Leider falsch.";
            }

            // Fortschritt speichern
            // ... (restlicher Code unverändert)
            
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
