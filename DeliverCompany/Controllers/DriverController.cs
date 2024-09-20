using DeliverCompany.Data;
using DeliverCompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeliverCompany.Controllers
{
    public class DriverController : Controller
    {
        private readonly AppDbContext _context;

        public DriverController(AppDbContext context)
        {
            _context = context;
        }


        // GET: Driver/Index
        public async Task<IActionResult> Index(string searchString)
        {
            var drivers = from d in _context.Drivers select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                drivers = drivers.Where(s => s.DriverName.Contains(searchString));
            }

            return View(await drivers.ToListAsync());

        }

        // GET: Driver/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Driver/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(
            "DriverID,DriverName,CarReg,NoteDate,NoteDescription,ResponsibleEmployee,BeloppUt,BeloppIn,TotalBeloppUt,TotalBeloppIn")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            Response.StatusCode = 400;
            return View(driver);
        }

        // GET: Driver/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        // POST: Driver/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DriverID,DriverName,CarReg,NoteDate,NoteDescription,ResponsibleEmployee,BeloppUt,BeloppIn,TotalBeloppUt,TotalBeloppIn")] Driver driver)
        {
            if (id != driver.DriverID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriverExists(driver.DriverID))
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
            return View(driver);
        }

        private bool DriverExists(int id)
        {
            return _context.Drivers.Any(e => e.DriverID == id);
        }

    }

}
