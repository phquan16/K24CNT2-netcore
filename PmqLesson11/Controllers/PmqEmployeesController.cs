
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PmqLesson11.Models;

public class PmqEmployeesController : Controller
{
    private readonly PmqEmployeeLesson11Context _context;

    public PmqEmployeesController(PmqEmployeeLesson11Context context)
    {
        _context = context;
    }

    // GET: PMQEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.PmqEmployees.ToListAsync());
    }

    // GET: PMQEMPLOYEES/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pmqemployee = await _context.PmqEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pmqemployee == null)
        {
            return NotFound();
        }

        return View(pmqemployee);
    }

    // GET: PMQEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PMQEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,PmqName,PmqGender,PmqBirthDay,PmqEmail,PmqPhone,PmqActive")] PmqEmployee pmqemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(pmqemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(pmqemployee);
    }

    // GET: PMQEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pmqemployee = await _context.PmqEmployees.FindAsync(id);
        if (pmqemployee == null)
        {
            return NotFound();
        }
        return View(pmqemployee);
    }

    // POST: PMQEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,PmqName,PmqGender,PmqBirthDay,PmqEmail,PmqPhone,PmqActive")] PmqEmployee pmqemployee)
    {
        if (id != pmqemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(pmqemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PmqEmployeeExists(pmqemployee.Id))
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
        return View(pmqemployee);
    }

    // GET: PMQEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pmqemployee = await _context.PmqEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pmqemployee == null)
        {
            return NotFound();
        }

        return View(pmqemployee);
    }

    // POST: PMQEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var pmqemployee = await _context.PmqEmployees.FindAsync(id);
        if (pmqemployee != null)
        {
            _context.PmqEmployees.Remove(pmqemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PmqEmployeeExists(long? id)
    {
        return _context.PmqEmployees.Any(e => e.Id == id);
    }
}
