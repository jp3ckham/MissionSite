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

        public ViewResult MissionChosen(string MissionName)
        {
            //this is the logic after you click dropdown this fills the viewbag for the page
            if (MissionName.Equals("1"))
            {   
                //philippines
                ViewBag.NameOfMission = "Philippines, Cavite";
                ViewBag.PresidentName = "President Aaron B. Speirs";
                ViewBag.MissionAddress = "Avenida St. Pag-asa Subdivision \nMolino, Bacoor City \n4102 Cavite Philippines";
                ViewBag.Language = "Tagalog";
                ViewBag.Climate = "Tropical Rainforest";
                ViewBag.DomReligion = "Catholic";
                ViewBag.Flag = "philflag.png";
            }
            else if (MissionName.Equals("2"))
            {
                //Mozambique
                ViewBag.NameOfMission = "Africa, Mozambique Maputo";
                ViewBag.PresidentName = "President Joni Koch";
                ViewBag.MissionAddress = "Caixa postal 1166 Correio \nCentral Maputo, Maputo, Mozambique";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "Tropical";
                ViewBag.DomReligion = "Catholic";
                ViewBag.Flag = "Mozflag.png";
            }
            else if (MissionName.Equals("3"))
            {
                //Mexico
                ViewBag.NameOfMission = "Mexico, Mexico City Southeast";
                ViewBag.PresidentName = "President Lindsay K. Mann";
                ViewBag.MissionAddress = "Av. del Taller 540 \nCol. Jardin Balbuna del Venustiano Carranza \nCiudad de Mexico, Mexico  15900";
                ViewBag.Language = "Spanish";
                ViewBag.Climate = "Subtropical";
                ViewBag.DomReligion = "Catholic";
                ViewBag.Flag = "mexflag.jpg";
            }


            return View("FAQ");
        }


        // GET: SelectedMission
        public ActionResult Index()
        {
            return View();
        }
    }
}