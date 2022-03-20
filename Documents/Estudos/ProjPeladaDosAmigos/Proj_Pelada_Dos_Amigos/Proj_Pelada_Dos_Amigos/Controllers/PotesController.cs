#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proj_Pelada_Dos_Amigos.Models;

namespace Proj_Pelada_Dos_Amigos.Controllers
{
    public class PotesController : Controller
    {
        private readonly Context _context;

        public PotesController(Context context)
        {
            _context = context;
        }

        // GET: Potes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Potes.ToListAsync());
        }

        // GET: Potes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pote = await _context.Potes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pote == null)
            {
                return NotFound();
            }

            return View(pote);
        }

        // GET: Potes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Potes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Pote pote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pote);
        }

        // GET: Potes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pote = await _context.Potes.FindAsync(id);
            if (pote == null)
            {
                return NotFound();
            }
            return View(pote);
        }

        // POST: Potes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Pote pote)
        {
            if (id != pote.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoteExists(pote.Id))
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
            return View(pote);
        }

        // GET: Potes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pote = await _context.Potes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pote == null)
            {
                return NotFound();
            }

            return View(pote);
        }

        // POST: Potes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pote = await _context.Potes.FindAsync(id);
            _context.Potes.Remove(pote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoteExists(int id)
        {
            return _context.Potes.Any(e => e.Id == id);
        }
    }
}
