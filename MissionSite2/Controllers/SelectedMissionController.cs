using MissionSite2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class SelectedMissionController : Controller
    {
        public MissionSite2Context db = new MissionSite2Context();

        public ActionResult Mission()
        { 
            ViewBag.Missions = db.Mission.ToList();
            return View();
        }

        [HttpGet]
        public ViewResult MissionChosen(FormCollection form)
        {
            //this is the logic after you click dropdown this fills the viewbag for the page


                ViewBag.NameOfMission = "";
                ViewBag.PresidentName = "";
                ViewBag.MissionAddress = "";
                ViewBag.Language = "";
                ViewBag.Climate = "";
                ViewBag.DomReligion = "";
                ViewBag.Flag = "";

            return View("FAQ");
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}