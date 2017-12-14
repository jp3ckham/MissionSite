using MissionSite2.DAL;
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

        public ViewResult MissionChosen(int id)
        {   
            //Lookup the missionID and return the data for that mission
            ViewBag.NameOfMission = db.Mission.Find(id).MissionName;
            ViewBag.PresidentName = db.Mission.Find(id).MissionPresidentName;
            ViewBag.MissionAddress = db.Mission.Find(id).MissionAddress;
            ViewBag.Language = db.Mission.Find(id).MissionLanguage;
            ViewBag.Climate = db.Mission.Find(id).MissionClimate;
            ViewBag.DomReligion = db.Mission.Find(id).DominantReligion;
            ViewBag.Flag = db.Mission.Find(id).MissionFlag;

            return View("FAQ");
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}