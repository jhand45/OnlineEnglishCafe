using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineEnglishCafe.Data;
using OnlineEnglishCafe.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnlineEnglishCafe.Controllers
{
    [AllowAnonymous]
    public class ProofreadingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProofreadingController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Proofreading
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProofreadingApplication.ToListAsync());
        }

        // GET: Proofreading/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proofreadingApplication = await _context.ProofreadingApplication
                .SingleOrDefaultAsync(m => m.Id == id);
            if (proofreadingApplication == null)
            {
                return NotFound();
            }

            return View(proofreadingApplication);
        }

        // GET: Proofreading/Apply
        public IActionResult Apply()
        {
            return View();
        }

        // POST: Proofreading/Apply
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Apply([Bind("Id,FirstName,SecondName,Email,Type,Purpose")] ProofreadingApplication proofreadingApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proofreadingApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction("Confirmed");
            }
            return View(proofreadingApplication);
        }

        //Post: Proofreading/Create Confirmation
        public IActionResult Confirmed()
        {
            return View();
        }


        // GET: Proofreading/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proofreadingApplication = await _context.ProofreadingApplication.SingleOrDefaultAsync(m => m.Id == id);
            if (proofreadingApplication == null)
            {
                return NotFound();
            }
            return View(proofreadingApplication);
        }

        // POST: Proofreading/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,SecondName,Email,Type,Purpose")] ProofreadingApplication proofreadingApplication)
        {
            if (id != proofreadingApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proofreadingApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProofreadingApplicationExists(proofreadingApplication.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(proofreadingApplication);
        }

        // GET: Proofreading/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proofreadingApplication = await _context.ProofreadingApplication
                .SingleOrDefaultAsync(m => m.Id == id);
            if (proofreadingApplication == null)
            {
                return NotFound();
            }

            return View(proofreadingApplication);
        }

        // POST: Proofreading/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proofreadingApplication = await _context.ProofreadingApplication.SingleOrDefaultAsync(m => m.Id == id);
            _context.ProofreadingApplication.Remove(proofreadingApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProofreadingApplicationExists(int id)
        {
            return _context.ProofreadingApplication.Any(e => e.Id == id);
        }
    }
}
