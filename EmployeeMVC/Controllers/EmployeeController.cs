using EmployeeMVC.Models;
using EmployeeMVC.Service.Impl;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService= new EmployeeService();
        }

        public IActionResult Index()
        {
            return View(_employeeService.GetAll());
        }

        //HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        //HTTP POST VERSION
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Create(employee);
            return View("Thanks", employee);
        }

        public IActionResult Detail(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //HTTP GET VERSION
        public IActionResult Update(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View(employee);
        }

        //HTTP POST VERSION
        [HttpPost]
        public IActionResult Update(Employee employee, int id)
        {
            _employeeService.Update(employee, id);
            return RedirectToAction(nameof(Index));
        }
    }
}
