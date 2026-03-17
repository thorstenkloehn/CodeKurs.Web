using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Data;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class ProgressController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private const string DefaultUserId = "guest_user";

    public ProgressController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("submit")]
    public async Task<IActionResult> SubmitProgress([FromBody] SubmitProgressRequest request)
    {
        if (request == null || request.TaskId <= 0)
        {
            return BadRequest(new { error = "Ungültige Anfrage." });
        }

        try
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == request.TaskId);
            if (task == null) return NotFound(new { error = "Aufgabe nicht gefunden." });

            var progress = await _context.Progress
                .FirstOrDefaultAsync(p => p.TaskId == task.Id && p.UserId == DefaultUserId);
            
            if (progress == null)
            {
                progress = new UserProgress
                {
                    TaskId = task.Id,
                    UserId = DefaultUserId, // Später echte User-IDs aus dem Token/Session
                    LastSubmittedCode = request.Code ?? string.Empty,
                    IsCompleted = request.IsCompleted,
                    LastUpdated = DateTime.UtcNow
                };
                _context.Progress.Add(progress);
            }
            else
            {
                progress.LastSubmittedCode = request.Code ?? string.Empty;
                if (request.IsCompleted) progress.IsCompleted = true; // Fortschritt bleibt bestehen, auch wenn danach falsch eingereicht wird
                progress.LastUpdated = DateTime.UtcNow;
            }
            
            await _context.SaveChangesAsync();

            return Ok(new { success = true, isCompleted = progress.IsCompleted });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = $"Fehler: {ex.Message}" });
        }
    }
}

public class SubmitProgressRequest
{
    public int TaskId { get; set; }
    public string? Code { get; set; }
    public bool IsCompleted { get; set; }
}
