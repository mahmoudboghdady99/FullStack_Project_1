using FirstApp2.BL;
using Microsoft.AspNetCore.Mvc;
using FirstApp2.Models;

namespace FirstApp2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Employees : Controller
    {
        public IActionResult List()
        {
            ClsEmployee employeeService = new ClsEmployee();
            var employees = employeeService.GetData();
            return View(employees);
        }

        public IActionResult Edit()
        {
           
            return View(new EmployeeModel());
        }

        [HttpPost]
        public IActionResult Save(EmployeeModel employee, string Email)
        {

            return View("Edit", employee);
        }
    }
}
