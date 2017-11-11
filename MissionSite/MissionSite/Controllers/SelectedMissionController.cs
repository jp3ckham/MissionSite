using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class SelectedMissionController : Controller
    {
        public ActionResult Mission()
        {
            List<SelectListItem> missions = new List<SelectListItem>();
            missions.Add(new SelectListItem { Text = "Select a mission", Value = "0" });
            missions.Add(new SelectListItem { Text = "Philippines, Cavite", Value = "1" });
            missions.Add(new SelectListItem { Text = "Africa, Mozambique Maputo", Value = "2" });
            missions.Add(new SelectListItem { Text = "Mexico, Mexico City Southeast", Value = "3" });
            ViewBag.MissionName = missions;
            return View();
        }

        public ViewResult MissionChosen(string MissionName)
        {
            if (MissionName.Equals("0"))
                ViewBag.messageString = "Colorado";
            else if (MissionName.Equals("1"))
                ViewBag.messageString = "Texas";
            else if (MissionName.Equals("2"))
                ViewBag.messageString = "Utah";

            return View("FAQ");
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}