using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreamClass.Models;

namespace StreamClass.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()//test
        {
            return View();
        }



        public IActionResult Conditions()
        {
            return View();
        }

        public IActionResult Mentions()
        {
            return View();
        }

        public IActionResult Contact()
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
