using Microsoft.AspNetCore.Mvc;

namespace FirstApp2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Employees : Controller
    {
       
        public IActionResult List()
        {
            return View();
        }
    }
}
