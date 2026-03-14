using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Data;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Tasks.Include(t => t.Lesson).ToListAsync());
    }

    public async Task<IActionResult> Create()
    {
        ViewBag.Lessons = await _context.Lessons.OrderBy(l => l.Title).ToListAsync();
        return View(new ProgrammingTask());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProgrammingTask task)
    {
        if (ModelState.IsValid)
        {
            _context.Add(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Lessons = await _context.Lessons.OrderBy(l => l.Title).ToListAsync();
        return View(task);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var task = await _context.Tasks.FindAsync(id);
        if (task == null) return NotFound();
        ViewBag.Lessons = await _context.Lessons.OrderBy(l => l.Title).ToListAsync();
        return View(task);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, ProgrammingTask task)
    {
        if (id != task.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(task);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(task.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Lessons = await _context.Lessons.OrderBy(l => l.Title).ToListAsync();
        return View(task);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var task = await _context.Tasks.FirstOrDefaultAsync(m => m.Id == id);
        if (task == null) return NotFound();
        return View(task);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task != null)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    private bool TaskExists(int id)
    {
        return _context.Tasks.Any(e => e.Id == id);
    }
}
