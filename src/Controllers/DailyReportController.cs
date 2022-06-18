using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Daycare.Models;

namespace Daycare.Controllers
{
    public class DailyReportController : Controller
    {
        private readonly Context _context;

        public DailyReportController(Context context)
        {
            _context = context;
        }

        // GET: DailyReport
        public async Task<IActionResult> Index()
        {
            return _context.DailyReports != null ?
                        View(await _context.DailyReports.Include(b => b.Student).ToListAsync()) :
                        Problem("Entity set 'Context.DailyReports'  is null.");
        }

        // GET: DailyReport/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DailyReports == null)
            {
                return NotFound();
            }

            var dailyReport = await _context.DailyReports.Include(b => b.Student)
                .FirstOrDefaultAsync(m => m.DailyReportId == id);
            if (dailyReport == null)
            {
                return NotFound();
            }

            return View(dailyReport);
        }

        // GET: DailyReport/Create
        public async Task<IActionResult> Create()
        {
            var students = await _context.Students.ToListAsync();
            ViewData["Students"] = new SelectList(_context.Students, nameof(Student.StudentId), nameof(Student.Name));
            return View();
        }

        // POST: DailyReport/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DailyReport @dailyReport)
        {
            Student? student = await _context.Students.FindAsync(dailyReport.StudentId);

            if (student != null)
            {
                dailyReport.Student = student;
                _context.DailyReports.Add(@dailyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dailyReport);
        }

        // GET: DailyReport/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var students = await _context.Students.ToListAsync();
            ViewData["Students"] = new SelectList(_context.Students, nameof(Student.StudentId), nameof(Student.Name));

            if (id == null || _context.DailyReports == null)
            {
                return NotFound();
            }

            var dailyReport = await _context.DailyReports.FindAsync(id);
            if (dailyReport == null)
            {
                return NotFound();
            }
            return View(dailyReport);
        }

        // POST: DailyReport/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,DailyReportId,Behavior,NumberOfPoops")] DailyReport dailyReport)
        {
            if (id != dailyReport.DailyReportId)
            {
                return NotFound();
            }

            Student? student = await _context.Students.FindAsync(dailyReport.StudentId);

            if (student != null)
            {
                try
                {
                    _context.Update(dailyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyReportExists(dailyReport.DailyReportId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dailyReport);
        }

        // GET: DailyReport/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DailyReports == null)
            {
                return NotFound();
            }

            var dailyReport = await _context.DailyReports
                .FirstOrDefaultAsync(m => m.DailyReportId == id);
            if (dailyReport == null)
            {
                return NotFound();
            }

            return View(dailyReport);
        }

        // POST: DailyReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DailyReports == null)
            {
                return Problem("Entity set 'Context.DailyReports'  is null.");
            }
            var dailyReport = await _context.DailyReports.FindAsync(id);
            if (dailyReport != null)
            {
                _context.DailyReports.Remove(dailyReport);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DailyReportExists(int id)
        {
            return (_context.DailyReports?.Any(e => e.DailyReportId == id)).GetValueOrDefault();
        }
    }
}
