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
        public static IEnumerable<MissionQuestions> missionquestions = null;
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

        //users have to log in to view the mission faq page... this pulls the info from our database and stores it in the viewbag
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

            missionquestions = db.Database.SqlQuery<MissionQuestions>("SELECT MissionQuestionID, MissionID, UserEmail, Question, Answer FROM MissionQuestions WHERE MissionID = " + mission.MissionID);

            return View(missionquestions);
        }

        //Post method to answer a question. Passes information from the form on the FAQ page and updates the answer in the d
        [HttpPost]
        public ActionResult AnswerQuestion(FormCollection form)
        {
            MissionQuestions updateQuestion = db.MissionQuestion.Find(int.Parse(form["MissionQuestionID"]));
            updateQuestion.Answer = form["newAnswer"];
            db.SaveChanges();

            return RedirectToAction("FAQ", missionquestions);
        }

        //Post method to ask a question. Passes information from form and puts it in the database
        [HttpPost]
        public ActionResult AskQuestion(FormCollection form)
        {
            var newQuestion = db.MissionQuestion.Add(new MissionQuestions());
            newQuestion.Question = form["newAskedQuestion"];
            newQuestion.MissionID = int.Parse(form["MissionID"]);
            db.SaveChanges();

            return RedirectToAction("FAQ", missionquestions);
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}