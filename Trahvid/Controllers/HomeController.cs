using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trahvid.Models;

namespace Trahvid.Controllers
{
    public class HomeController : Controller
    {
        TrahvidContext db = new TrahvidContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Traahv()
        {
            IEnumerable<Traahv> traahvs = db.Traahv1.ToList(); // Fetch the data from the database
            return View(traahvs); // Pass the data to the view
        }

    }
}