using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DeliverCompany.Models;
using System.Threading.Tasks;

namespace DeliverCompany.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly UserManager<Employee> _userManager;

        public EmployeeController(UserManager<Employee> userManager)
        {
            _userManager = userManager;
        }

        // Visa alla anställda (Index)
        public IActionResult Index()
        {
            var employees = _userManager.Users;
            return View(employees); // Returnerar en lista av Employee
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public async Task<IActionResult> Create(string email, string name, string password)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee
                {
                    UserName = email,
                    Email = email,
                    Name = name
                };

                var result = await _userManager.CreateAsync(employee, password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var employee = await _userManager.FindByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string name)
        {
            var employee = await _userManager.FindByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.Email = email;
            employee.Name = name;

            var result = await _userManager.UpdateAsync(employee);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var employee = await _userManager.FindByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employee = await _userManager.FindByIdAsync(id);
            if (employee != null)
            {
                var result = await _userManager.DeleteAsync(employee);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(employee);
        }
    }
}
