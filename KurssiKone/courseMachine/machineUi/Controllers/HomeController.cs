using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace machineUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "";
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Hub()
        {
            ViewBag.Title = "hub";
            return View();
        }

        public ActionResult courseConfig()
        {
            ViewBag.Title = "config";
            return View();
        }

        public ActionResult courseViewer()
        {
            ViewBag.Title = "viewer";
            return View();
        }
    }
}