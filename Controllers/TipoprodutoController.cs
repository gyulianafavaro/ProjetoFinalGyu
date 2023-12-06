using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Login.Models;

namespace Projeto_Login.Controllers
{
    public class TipoprodutoController : Controller
    {
        private readonly Contexto _context;

        public TipoprodutoController(Contexto context)
        {
            _context = context;
        }

        // GET: Tipoproduto
        public async Task<IActionResult> Index()
        {
              return _context.Tipoproduto != null ? 
                          View(await _context.Tipoproduto.ToListAsync()) :
                          Problem("Entity set 'Contexto.Tipoproduto'  is null.");
        }

        // GET: Tipoproduto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tipoproduto == null)
            {
                return NotFound();
            }

            var tipoproduto = await _context.Tipoproduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoproduto == null)
            {
                return NotFound();
            }

            return View(tipoproduto);
        }

        // GET: Tipoproduto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipoproduto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoProdutoDescricao")] Tipoproduto tipoproduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoproduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoproduto);
        }

        // GET: Tipoproduto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tipoproduto == null)
            {
                return NotFound();
            }

            var tipoproduto = await _context.Tipoproduto.FindAsync(id);
            if (tipoproduto == null)
            {
                return NotFound();
            }
            return View(tipoproduto);
        }

        // POST: Tipoproduto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoProdutoDescricao")] Tipoproduto tipoproduto)
        {
            if (id != tipoproduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoproduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoprodutoExists(tipoproduto.Id))
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
            return View(tipoproduto);
        }

        // GET: Tipoproduto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tipoproduto == null)
            {
                return NotFound();
            }

            var tipoproduto = await _context.Tipoproduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoproduto == null)
            {
                return NotFound();
            }

            return View(tipoproduto);
        }

        // POST: Tipoproduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tipoproduto == null)
            {
                return Problem("Entity set 'Contexto.Tipoproduto'  is null.");
            }
            var tipoproduto = await _context.Tipoproduto.FindAsync(id);
            if (tipoproduto != null)
            {
                _context.Tipoproduto.Remove(tipoproduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoprodutoExists(int id)
        {
          return (_context.Tipoproduto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
