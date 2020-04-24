using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StreamClass.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace StreamClass.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _variable_env;
        private readonly string _cheminVideo = "\\Videos\\video.mp4";


        public IActionResult Index()
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

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HomeController(IHostingEnvironment variableEnv)
        {
            _variable_env = variableEnv;
        }

        public IActionResult GetVideo()
        {
            string cheminVideoComplet = _variable_env.ContentRootPath + _cheminVideo;

            FileStream stream = new FileStream(cheminVideoComplet, FileMode.Open);
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}
