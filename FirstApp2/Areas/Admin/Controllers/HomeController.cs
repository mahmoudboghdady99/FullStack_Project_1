﻿using Microsoft.AspNetCore.Mvc;

namespace FirstApp2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
