using MissionSite2.DAL;
using MissionSite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MissionSite.Controllers
{
    public class SelectedMissionController : Controller
    {
        public static Mission mission = null;
        //Create Database context variable
        public MissionSite2Context db = new MissionSite2Context();

        //Put missions in a list for the dropdown list in the view
        [AllowAnonymous]
        public ActionResult Mission()
        {
            ViewBag.Missions = db.Mission.ToList();
            return View();
        }

        
        [HttpPost]
        public ActionResult MissionChosen(int? missionID)
        {
            //this is the logic after you click dropdown this fills the viewbag for the page
            mission = db.Mission.Find(missionID);

            return RedirectToAction("FAQ");
        }

        [Authorize]
        public ActionResult FAQ()
        {

            ViewBag.NameOfMission = mission.MissionName;
            ViewBag.PresidentName = mission.MissionPresidentName;
            ViewBag.MissionAddress = mission.MissionAddress;
            ViewBag.Language = mission.MissionLanguage;
            ViewBag.Climate = mission.MissionClimate;
            ViewBag.DomReligion = mission.DominantReligion;
            ViewBag.Flag = mission.MissionFlag;

            IEnumerable<MissionQuestions> missionquestions =
               db.Database.SqlQuery<MissionQuestions>("SELECT MissionQuestionID, MissionID, UserID, Question, Answer FROM MissionQuestions WHERE MissionID = " + mission.MissionID);

            return View(missionquestions);
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}