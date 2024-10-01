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
        public async Task<IActionResult> Index(string searchString, DateTime? fromNoteDate, DateTime? toNoteDate)
        {
            var drivers = from d in _context.Drivers select d;

            // Filtrering baserat på namn
            if (!string.IsNullOrEmpty(searchString))
            {
                drivers = drivers.Where(d => d.DriverName.Contains(searchString));
            }

            // Filtrering baserat på NoteDate (datumintervall)
            if (fromNoteDate.HasValue && toNoteDate.HasValue)
            {
                drivers = drivers.Where(d => d.NoteDate >= fromNoteDate && d.NoteDate <= toNoteDate);
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
        public async Task<IActionResult> Edit(int id, [Bind("DriverID,DriverName,CarReg,ResponsibleEmployee")] Driver driver)
        {
            if (id != driver.DriverID)
            {
                return NotFound();
            }

            try
            {
                var existingDriver = await _context.Drivers.FindAsync(id);
                if (existingDriver == null)
                {
                    return NotFound();
                }

                // Uppdatera fälten utan att använda ModelState.IsValid
                existingDriver.DriverName = driver.DriverName;
                existingDriver.CarReg = driver.CarReg;
                existingDriver.ResponsibleEmployee = driver.ResponsibleEmployee;

                // Försök att spara ändringarna
                await _context.SaveChangesAsync();

                // Omdirigera till Index efter att ändringarna sparats
                return RedirectToAction(nameof(Index));
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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return View(driver); // Skicka tillbaka användaren till samma vy om något går fel
        }







        // GET: Driver/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers
                .FirstOrDefaultAsync(m => m.DriverID == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: Driver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool DriverExists(int id)
        {
            return _context.Drivers.Any(e => e.DriverID == id);
        }

        // GET: Driver/AddEvent/1
        public IActionResult AddEvent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = _context.Drivers.Find(id);
            if (driver == null)
            {
                return NotFound();
            }

            var model = new Event { DriverID = driver.DriverID, NoteDate = DateTime.Now };
            return View(model);
        }


        // POST: Driver/AddEvent/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEvent([Bind("EventID,DriverID,EventDate,NoteDescription,BeloppIn,BeloppUt")] Event @event)
        {
            if (ModelState.IsValid)
            {
                var driver = await _context.Drivers.FindAsync(@event.DriverID);
                if (driver == null)
                {
                    ModelState.AddModelError("", "Föraren hittades inte.");
                    return View(@event);
                }

                try
                {
                    _context.Events.Add(@event);
                    await _context.SaveChangesAsync();  // Viktigt att spara till databasen
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); // Lägg till logging om något går fel
                }

                return RedirectToAction("Details", new { id = @event.DriverID });
            }

            // Visa felmeddelanden om något är fel
            return View(@event);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var driver = await _context.Drivers
                                       .Include(d => d.Events) // Ladda relaterade events
                                       .FirstOrDefaultAsync(m => m.DriverID == id);

            if (driver == null) return NotFound();

            return View(driver);
        }


    }

}
