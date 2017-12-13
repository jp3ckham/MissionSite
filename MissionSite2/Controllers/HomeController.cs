using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {   
        //calls the index view
        public ActionResult Index()
        {
            return View();
        }

        //calls the about view
        public ActionResult About()
        {
            ViewBag.Message = "Hello";

            return View();
        }

        //calls the contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}