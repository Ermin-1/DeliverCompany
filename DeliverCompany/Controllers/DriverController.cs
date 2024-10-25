using DeliverCompany.Data;
using DeliverCompany.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeliverCompany.Controllers
{
    public class DriverController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<DriverController> _logger;

        public DriverController(AppDbContext context, ILogger<DriverController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Index(string searchString, DateTime? fromNoteDate, DateTime? toNoteDate)
        {
            var drivers = _context.Drivers.Include(d => d.Events).AsQueryable();

            // Filtrering baserat på namn
            if (!string.IsNullOrEmpty(searchString))
            {
                drivers = drivers.Where(d => d.DriverName.Contains(searchString));
            }

            // Filtrering baserat på NoteDate (datumintervall)
            if (fromNoteDate.HasValue && toNoteDate.HasValue)
            {
                drivers = drivers.Where(d => d.Events.Any(e => e.NoteDate >= fromNoteDate && e.NoteDate <= toNoteDate));
            }

            return View(await drivers.ToListAsync());
        }



        // GET: Driver/Create
        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Driver/Create
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DriverID,DriverName,CarReg,ResponsibleEmployee")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driver);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Driver created successfully: {DriverID}", driver.DriverID);
                return RedirectToAction(nameof(Index));
            }

            // Loggar varför ModelState är ogiltig
            _logger.LogWarning("ModelState is invalid. Errors:");

            foreach (var modelState in ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    _logger.LogWarning("Validation Error: {ErrorMessage}", error.ErrorMessage);
                }
            }

            Response.StatusCode = 400;
            return View(driver);
        }



        // GET: Driver/Edit/5
        [Authorize(Roles = "Admin, Employee")]
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
        [Authorize(Roles = "Admin, Employee")]
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
                // Hämta den befintliga föraren från databasen
                var existingDriver = await _context.Drivers
                                                   .Include(d => d.Events) // Inkludera events för att kunna uppdatera dem
                                                   .FirstOrDefaultAsync(d => d.DriverID == id);
                if (existingDriver == null)
                {
                    return NotFound();
                }

                // Uppdatera förare
                existingDriver.DriverName = driver.DriverName;
                existingDriver.CarReg = driver.CarReg;
                existingDriver.ResponsibleEmployee = driver.ResponsibleEmployee;

                // Spara ändringarna
                await _context.SaveChangesAsync();
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
        }



        // GET: Driver/Delete/5
        [Authorize(Roles = "Admin, Employee")]
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
        [Authorize(Roles = "Admin, Employee")]
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
        [Authorize(Roles = "Admin, Employee")]
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
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEvent([Bind("EventID,DriverID,NoteDate,NoteDescription,BeloppIn,BeloppUt")] Event @event)
        {
            // Logga DriverID för att se om det skickas korrekt
            _logger.LogInformation($"AddEvent POST: Received DriverID: {@event.DriverID}");

            if (@event.DriverID == 0)
            {
                _logger.LogError("AddEvent POST: DriverID is missing or invalid.");
                ModelState.AddModelError("", "DriverID is missing or invalid.");
                return View(@event);
            }

            // Koppla bort Driver-navigationsfältet från bindningen
            @event.Driver = null;

            if (ModelState.IsValid)
            {
                _logger.LogInformation("AddEvent POST: ModelState is valid.");

                var driver = await _context.Drivers.FindAsync(@event.DriverID);
                if (driver == null)
                {
                    _logger.LogWarning($"AddEvent POST: Driver with ID {@event.DriverID} not found.");
                    ModelState.AddModelError("", "Föraren hittades inte.");
                    return View(@event);
                }

                try
                {
                    _logger.LogInformation("AddEvent POST: Adding new event to database.");
                    _context.Events.Add(@event);
                    await _context.SaveChangesAsync();  // Spara ändringar
                    _logger.LogInformation("AddEvent POST: Event successfully saved.");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"AddEvent POST: Error occurred while saving event. Exception: {ex.Message}");
                }

                return RedirectToAction("Details", new { id = @event.DriverID });
            }
            else
            {
                _logger.LogWarning("AddEvent POST: ModelState is invalid.");
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    _logger.LogWarning($"Validation error: {error.ErrorMessage}");
                }
            }

            _logger.LogInformation("AddEvent POST: Returning view with errors.");
            return View(@event);
        }




        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var driver = await _context.Drivers
                                       .Include(d => d.Events) // Ladda relaterade events
                                       .FirstOrDefaultAsync(m => m.DriverID == id);

            if (driver == null) return NotFound();

            // Beräkna totalerna
            driver.TotalBeloppIn = driver.Events.Sum(e => e.BeloppIn);
            driver.TotalBeloppUt = driver.Events.Sum(e => e.BeloppUt);

            return View(driver);
        }





        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> RecentEvents()
        {
            // Hämta datum och tid från 12 timmar tillbaka
            DateTime last12Hours = DateTime.Now.AddHours(-12);

            // Hämta alla förare och inkludera deras händelser
            var drivers = await _context.Drivers
                .Include(d => d.Events)
                .ToListAsync();

            // Filtrera förare som har händelser från de senaste 12 timmarna
            var driversWithRecentEvents = drivers
                .Where(d => d.Events.Any(e => e.NoteDate >= last12Hours))
                .ToList();

            return View(driversWithRecentEvents);
        }


    }

}
