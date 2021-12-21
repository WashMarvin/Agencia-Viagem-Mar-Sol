using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaMareSol.Models;

namespace AgenciaMareSol.Controllers
{
    public class PassagensController : Controller
    {
        private readonly Context _context;

        public PassagensController(Context context)
        {
            _context = context;
        }

        // GET: Passagens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passagens.ToListAsync());
        }

        // GET: Passagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // GET: Passagens/Create
        public IActionResult Create()
        {
            ViewData["Contato_Id"] = new SelectList(_context.Contatos, dataValueField: "Id", dataTextField: "Id");
            ViewData["Promocao_Id"] = new SelectList(_context.Promoções, dataValueField: "Id", dataTextField: "Id");
            return View();
        }

        // POST: Passagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,Contato_Id,Promocao_Id")] Passagem passagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Contato_Id"] = new SelectList(_context.Contatos, dataValueField: "Id", dataTextField: "Id");
            ViewData["Promocao_Id"] = new SelectList(_context.Promoções, dataValueField: "Id", dataTextField: "Id");
            return View(passagem);
        }

        // GET: Passagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }

            ViewData["Contato_Id"] = new SelectList(_context.Contatos, dataValueField: "Id", dataTextField: "Id");
            ViewData["Promocao_Id"] = new SelectList(_context.Promoções, dataValueField: "Id", dataTextField: "Id");
            return View(passagem);
        }

        // POST: Passagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,Contato_Id,Promocao_Id")] Passagem passagem)
        {
            if (id != passagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassagemExists(passagem.Id))
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

            ViewData["Contato_Id"] = new SelectList(_context.Contatos, dataValueField: "Id", dataTextField: "Id");
            ViewData["Promocao_Id"] = new SelectList(_context.Promoções, dataValueField: "Id", dataTextField: "Id");
            return View(passagem);
        }

        // GET: Passagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // POST: Passagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passagem = await _context.Passagens.FindAsync(id);
            _context.Passagens.Remove(passagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassagemExists(int id)
        {
            return _context.Passagens.Any(e => e.Id == id);
        }
    }
}
