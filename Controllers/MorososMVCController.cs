using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagerAC.Data;

namespace StockManagerAC.Models
{
    [Authorize]
    public class MorososMVCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MorososMVCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MorososMVC
        public async Task<IActionResult> Index()
        {
            return View(await _context.Moroso.ToListAsync());
        }

        // GET: MorososMVC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moroso = await _context.Moroso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moroso == null)
            {
                return NotFound();
            }

            return View(moroso);
        }

        // GET: MorososMVC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MorososMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Detalle,Debe")] Moroso moroso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moroso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moroso);
        }

        // GET: MorososMVC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moroso = await _context.Moroso.FindAsync(id);
            if (moroso == null)
            {
                return NotFound();
            }
            return View(moroso);
        }

        // POST: MorososMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Detalle,Debe")] Moroso moroso)
        {
            if (id != moroso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moroso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MorosoExists(moroso.Id))
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
            return View(moroso);
        }

        // GET: MorososMVC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moroso = await _context.Moroso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moroso == null)
            {
                return NotFound();
            }

            return View(moroso);
        }

        // POST: MorososMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moroso = await _context.Moroso.FindAsync(id);
            _context.Moroso.Remove(moroso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MorosoExists(int id)
        {
            return _context.Moroso.Any(e => e.Id == id);
        }
    }
}
