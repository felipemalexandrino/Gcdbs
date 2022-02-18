using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gcdbs.Data;
using Gcdbs.Models;

namespace Gcdbs.Controllers
{
    public class MontadorasController : Controller
    {
        private readonly GcDbContext _context;

        public MontadorasController(GcDbContext context)
        {
            _context = context;
        }

        // GET: Montadoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Montadoras.ToListAsync());
        }

        // GET: Montadoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montadora = await _context.Montadoras
                .FirstOrDefaultAsync(m => m.IdMontadora == id);
            if (montadora == null)
            {
                return NotFound();
            }

            return View(montadora);
        }

        // GET: Montadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Montadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMontadora,NomeMontadora")] Montadora montadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(montadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(montadora);
        }

        // GET: Montadoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montadora = await _context.Montadoras.FindAsync(id);
            if (montadora == null)
            {
                return NotFound();
            }
            return View(montadora);
        }

        // POST: Montadoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMontadora,NomeMontadora")] Montadora montadora)
        {
            if (id != montadora.IdMontadora)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(montadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MontadoraExists(montadora.IdMontadora))
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
            return View(montadora);
        }

        // GET: Montadoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montadora = await _context.Montadoras
                .FirstOrDefaultAsync(m => m.IdMontadora == id);
            if (montadora == null)
            {
                return NotFound();
            }

            return View(montadora);
        }

        // POST: Montadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var montadora = await _context.Montadoras.FindAsync(id);
            _context.Montadoras.Remove(montadora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MontadoraExists(int id)
        {
            return _context.Montadoras.Any(e => e.IdMontadora == id);
        }
    }
}
