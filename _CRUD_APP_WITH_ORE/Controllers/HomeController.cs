using _CRUD_APP_WITH_ORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _CRUD_APP_WITH_ORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.data = "shivam";
            ViewBag.data1 = 1245;
            ViewBag.date= DateTime.Now;
            ViewBag.List = new List<string>()
            {
                "shivam",
                "aman"
            };

            ViewData["data"] = "shivam";
            ViewData["data1"] = 1245;
            ViewData["data2"] = DateTime.Now;
            ViewData["List"] = new List<string>()
            {
                "shivam",
                "aman"
            };
            TempData["data"] = "shivam";
            TempData["data1"] = 1245;
            TempData["data2"] = DateTime.Now;
            TempData["List"] = new List<string>()
            {
                "shivam",
                "aman"
            };
            return View();
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
