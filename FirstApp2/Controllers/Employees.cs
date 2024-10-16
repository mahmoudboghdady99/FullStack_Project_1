using Microsoft.AspNetCore.Mvc;
using FirstApp2.Models;

using FirstApp2.BL; // يجب إضافة الـ namespace الجديد الذي يحتوي على الكلاس

namespace FirstApp2.Controllers
{
    public class Employees : Controller
    {

        ClsEmployee employeeService = new ClsEmployee();  // تعديل اسم الكلاس


        public IActionResult List()
        {
            var LstEmployees = employeeService.GetData();  // استدعاء الميثود GetData
            return View(LstEmployees);
        }
        public IActionResult Details(int id, string name)
        {
            var myEmployee = employeeService.GetData().FirstOrDefault(a => a.Id == id);  // أو استخدم Find لو قمت بتعديلها
            return View(myEmployee);
        }

    }
}
