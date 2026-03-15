using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Data;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Controllers;

public class DashboardController : Controller
{
    private readonly ApplicationDbContext _context;

    public DashboardController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var tasks = await _context.Tasks.ToListAsync();
        var progress = await _context.Progress
            .Where(p => p.UserId == "guest")
            .ToListAsync();

        var viewModel = new DashboardViewModel
        {
            TotalTasks = tasks.Count,
            CompletedTasks = progress.Count(p => p.IsCompleted),
            TaskDetails = tasks.Select(t => {
                var p = progress.FirstOrDefault(pr => pr.TaskId == t.Id);
                return new TaskProgressInfo
                {
                    TaskId = t.Id,
                    Title = t.Title,
                    Language = t.Language,
                    Type = t.Type,
                    IsCompleted = p?.IsCompleted ?? false,
                    LastUpdated = p?.LastUpdated
                };
            }).ToList(),
            LanguageStats = tasks.GroupBy(t => t.Language).ToDictionary(
                g => g.Key,
                g => new LanguageStatInfo {
                    Total = g.Count(),
                    Completed = g.Count(t => progress.Any(p => p.TaskId == t.Id && p.IsCompleted))
                }
            )
        };

        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> ResetProgress()
    {
        var progress = await _context.Progress.Where(p => p.UserId == "guest").ToListAsync();
        _context.Progress.RemoveRange(progress);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}
