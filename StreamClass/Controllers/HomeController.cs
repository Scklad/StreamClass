﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StreamClass.Models;
using System.Diagnostics;
using System.IO;

namespace StreamClass.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _variable_env;
        private readonly string _cheminVideo = "\\Videos\\video.mp4";

        public HomeController(IHostingEnvironment variableEnv)
        {
            _variable_env = variableEnv;
        }

        public IActionResult Index()//test
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Video()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetVideo()
        {
            string cheminVideoComplet = _variable_env.ContentRootPath + _cheminVideo;

            FileStream stream = new FileStream(cheminVideoComplet, FileMode.Open);
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}