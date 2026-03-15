using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Data;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class LessonsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public LessonsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("courses")]
    public async Task<IActionResult> GetCourses()
    {
        var languages = await _context.Lessons
            .Select(l => l.Language)
            .Distinct()
            .ToListAsync();
            
        return Ok(languages);
    }

    [HttpGet("courses/{language}")]
    public async Task<IActionResult> GetLessonsForCourse(string language)
    {
        var lessons = await _context.Lessons
            .Include(l => l.Tasks)
            .Where(l => l.Language == language)
            .OrderBy(l => l.Order)
            .ToListAsync();

        if (!lessons.Any())
            return NotFound(new { error = $"Keine Lektionen für Sprache {language} gefunden." });

        // Wir entfernen rekursive Referenzen (falls vorhanden) um Endlosschleifen bei JSON Serialisierung zu vermeiden
        var result = lessons.Select(l => new {
            l.Id,
            l.Title,
            l.Description,
            l.Order,
            l.Language,
            Tasks = l.Tasks.OrderBy(t => t.Order).Select(t => new {
                t.Id,
                t.Title,
                t.Type,
                t.Order
            })
        });

        return Ok(result);
    }

    [HttpGet("tasks/{id}")]
    public async Task<IActionResult> GetTask(int id)
    {
        var task = await _context.Tasks
            .Include(t => t.Lesson)
            .FirstOrDefaultAsync(t => t.Id == id);

        if (task == null)
            return NotFound(new { error = "Aufgabe nicht gefunden." });

        // InitialCode ggf. aus bisherigem Fortschritt laden
        var progress = await _context.Progress
            .FirstOrDefaultAsync(p => p.TaskId == task.Id && p.UserId == "guest");
        
        string userCode = string.Empty;
        bool isCompleted = false;

        if (progress != null && !string.IsNullOrEmpty(progress.LastSubmittedCode))
        {
            userCode = progress.LastSubmittedCode;
            isCompleted = progress.IsCompleted;
        }
        else if (!string.IsNullOrEmpty(task.PlaceholderDependency) && int.TryParse(task.PlaceholderDependency, out int prevTaskId))
        {
            var prevProgress = await _context.Progress
                .FirstOrDefaultAsync(p => p.TaskId == prevTaskId && p.UserId == "guest");
            
            if (prevProgress != null && !string.IsNullOrEmpty(prevProgress.LastSubmittedCode))
            {
                userCode = prevProgress.LastSubmittedCode;
            }
        }

        return Ok(new {
            task.Id,
            task.Title,
            task.Description,
            task.Type,
            task.Language,
            InitialCode = string.IsNullOrEmpty(userCode) ? task.InitialCode : userCode,
            task.ExpectedOutput,
            task.Solution,
            task.ChoicesJson,
            task.CorrectAnswer,
            task.RequiredKeywords,
            task.TestCode,
            task.LessonId,
            LessonTitle = task.Lesson?.Title,
            IsCompleted = isCompleted
        });
    }

    [HttpGet("courses/{language}/next-task")]
    public async Task<IActionResult> GetNextTask(string language)
    {
        var completedTaskIds = await _context.Progress
            .Where(p => p.UserId == "guest" && p.IsCompleted)
            .Select(p => p.TaskId)
            .ToListAsync();

        var task = await _context.Tasks.Include(t => t.Lesson)
            .Where(t => t.Language == language && !completedTaskIds.Contains(t.Id))
            .OrderBy(t => t.LessonId).ThenBy(t => t.Order)
            .FirstOrDefaultAsync();

        if (task == null)
        {
            // Alle gelöst, nimm die erste
            task = await _context.Tasks.Include(t => t.Lesson)
                .Where(t => t.Language == language)
                .OrderBy(t => t.LessonId).ThenBy(t => t.Order)
                .FirstOrDefaultAsync();
        }

        if (task == null)
            return NotFound(new { error = "Keine Aufgaben für diese Sprache gefunden." });

        return Ok(new { TaskId = task.Id });
    }
}
