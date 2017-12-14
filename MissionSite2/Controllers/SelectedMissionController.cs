using MissionSite2.DAL;
using MissionSite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MissionSite2.Models;

namespace MissionSite.Controllers
{
    public class SelectedMissionController : Controller
    {
        //Create Database context variable
        public MissionSite2Context db = new MissionSite2Context();

        //Put missions in a list for the dropdown list in the view
        public ActionResult Mission()
        {
            ViewBag.Missions = db.Mission.ToList();
            return View();
        }

        [HttpPost]
        public ViewResult MissionChosen(int? missionID)
        {
            //this is the logic after you click dropdown this fills the viewbag for the page
            Mission mission = db.Mission.Find(missionID);
            ViewBag.NameOfMission = mission.MissionName;
            ViewBag.PresidentName = mission.MissionPresidentName;
            ViewBag.MissionAddress = mission.MissionAddress;
            ViewBag.Language = mission.MissionLanguage;
            ViewBag.Climate = mission.MissionClimate;
            ViewBag.DomReligion = mission.DominantReligion;
            ViewBag.Flag = mission.MissionFlag;


            return View("FAQ");
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}