using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PmqLesson10.Models;

namespace PmqLesson10.Controllers
{
    public class PmqMembersController : Controller
    {
        private readonly PmqK24cnt2Lesson10Context _context;

        public PmqMembersController(PmqK24cnt2Lesson10Context context)
        {
            _context = context;
        }

        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public async Task<IActionResult> Index()
        {
            return View(await _context.PmqMembers.AsNoTracking().ToListAsync());
        }

        // GET: PmqMembers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null) return NotFound();

            var pmqMember = await _context.PmqMembers
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MemberId == id);

            if (pmqMember == null) return NotFound();

            return View(pmqMember);
        }

        // GET: PmqMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PmqMembers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PmqUserName,PmqPassword,PmqFullName,PmqEmail,PmqPhone,PmqStatus")] PmqMember pmqMember)
        {
            ModelState.Remove("MemberId");

            if (ModelState.IsValid)
            {
                _context.Add(pmqMember);
                await _context.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index)); 
            }

            return View(pmqMember);
        }

        // GET: PmqMembers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null) return NotFound();

            var pmqMember = await _context.PmqMembers.FindAsync(id);
            if (pmqMember == null) return NotFound();

            return View(pmqMember);
        }

        // POST: PmqMembers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MemberId,PmqUserName,PmqPassword,PmqFullName,PmqEmail,PmqPhone,PmqStatus")] PmqMember pmqMember)
        {
            if (id != pmqMember.MemberId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pmqMember);
                    await _context.SaveChangesAsync(); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PmqMemberExists(pmqMember.MemberId)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index)); 
            }
            return View(pmqMember);
        }

        // GET: PmqMembers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null) return NotFound();

            var pmqMember = await _context.PmqMembers
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MemberId == id);

            if (pmqMember == null) return NotFound();

            return View(pmqMember);
        }

        // POST: PmqMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pmqMember = await _context.PmqMembers.FindAsync(id);
            if (pmqMember != null)
            {
                _context.PmqMembers.Remove(pmqMember);
                await _context.SaveChangesAsync(); 
            }

            return RedirectToAction(nameof(Index));
        }

        private bool PmqMemberExists(long id)
        {
            return _context.PmqMembers.Any(e => e.MemberId == id);
        }
    }
}