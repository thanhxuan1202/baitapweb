using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebDay5.Models;

namespace WebDay5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel { Id = 1, FullName = "Nguyễn Văn A", Gender = "Male", Phone = "0123456789", Email = "a@gmail.com", Salary = 5000, Status = true },
            new EmployeeModel { Id = 2, FullName = "Trần Thị B", Gender = "Female", Phone = "0987654321", Email = "b@gmail.com", Salary = 6000, Status = false }
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = employees.Max(e => e.Id) + 1;
                employees.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);
                if (existingEmployee != null)
                {
                    existingEmployee.FullName = employee.FullName;
                    existingEmployee.Gender = employee.Gender;
                    existingEmployee.Phone = employee.Phone;
                    existingEmployee.Email = employee.Email;
                    existingEmployee.Salary = employee.Salary;
                    existingEmployee.Status = employee.Status;
                }
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
