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



        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmail(string email)
        {
            if(false)
            {
                return Json($"email {email} is already in use ");

            }
            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
                return View("Edit", employee);

            
            // تنفيذ عملية الحفظ هنا

            return View("Edit", employee);
        }
    }
}
