using Microsoft.AspNetCore.Mvc;
using FirstApp2.Models;

namespace FirstApp2.Controllers
{
    public class Employees : Controller
    {
        List<EmployeeModel> LstEmployees;
        void createEmployeesList()
        {
            LstEmployees = new List<EmployeeModel>();
            EmployeeModel model = new EmployeeModel();
            model.Id = 1;
            model.Name = "Iron Man";
            model.Title = "Innovation";
            model.Description = "Description";
            model.ImageName = "1.jpg";
            LstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 2;
            model.Name = "BatMan";
            model.Title = "Developer";
            model.Description = "Description";
            model.ImageName = "2.jpg";
            LstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 3;
            model.Name = "Joie Doe";
            model.Title = "Actross";
            model.Description = "Description";
            model.ImageName = "3.jpg";
            LstEmployees.Add(model);
        }
        public IActionResult List()
        {
            createEmployeesList();
            return View(LstEmployees);
        }
        public IActionResult Details(int id, string name)
        {
            createEmployeesList();
            var myEmployee = LstEmployees.Where(a => a.Id == id).FirstOrDefault();
            return View(myEmployee);
        }

    }
}
