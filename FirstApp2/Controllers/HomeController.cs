using Microsoft.AspNetCore.Mvc;

namespace FirstApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Default()
        {
            return View();
        }
    }
}
