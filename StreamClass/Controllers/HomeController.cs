using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StreamClass.Context;
using StreamClass.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace StreamClass.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _variable_env;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Competence()
        {
            using (SQLServerContext db = new SQLServerContext())
            {
                var test = from comp in db.Competences
                           join sousthem in db.SousThemesCompetences
                           on comp.Id equals sousthem.IdCompetence
                           select comp;
            }

        public IActionResult Abonnement()
        {
            return View();
        }

        public IActionResult ParcoursPerso()
        {
            return View();
        }

        public IActionResult Cours()
        {
            return View();
        }

        public IActionResult SelectionModule()
        {
            return View();
        }

            public IActionResult SelectionVideo()
        {
            List<Video> listVideos = new List<Video>();

            using (SQLServerContext db = new SQLServerContext())
            {
                listVideos = db.Videos.ToList<Video>();
            }

            return View(listVideos);
        }

        public IActionResult Video(int id)
        {
            Video model;

            using (SQLServerContext db = new SQLServerContext())
            {
                model = db.Videos.Where(x => x.Id == id).FirstOrDefault();
            }

            return View(model);
        }

        public IActionResult Conditions()
        {
            return View();
        }

        public IActionResult Facture()
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

        public IActionResult GetVideo(int id)
        {
            //Récupération des données de la vidéo à partir de l'id
            Video model;

            using (SQLServerContext db = new SQLServerContext())
            {
                model = db.Videos.Where(x => x.Id == id).FirstOrDefault();
            }

            string cheminVideoComplet = _variable_env.ContentRootPath + model.Emplacement;

            FileStream stream = new FileStream(cheminVideoComplet, FileMode.Open);
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}
