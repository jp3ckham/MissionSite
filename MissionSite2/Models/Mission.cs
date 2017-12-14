using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite2.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }

        [Required(ErrorMessage = "The Mission Name is required")]
        [DisplayName("MissionName")]
        public string MissionName { get; set; }

        [Required(ErrorMessage = "The Mission President's Name is required")]
        [DisplayName("Mission President's Name")]
        public string MissionPresidentName { get; set; }

        [Required(ErrorMessage = "The Mission Address is required")]
        [DisplayName("Mission Address")]
        public string MissionAddress { get; set; }

        [Required(ErrorMessage = "The Mission Language is required")]
        [DisplayName("Mission Language")]
        public string MissionLanguage { get; set; }

        [Required(ErrorMessage = "The Mission Climate is required")]
        [DisplayName("Mission Climate")]
        public string MissionClimate { get; set; }

        [Required(ErrorMessage = "The Mission's Dominant Religion is required")]
        [DisplayName("Mission's Dominant Religion")]
        public string DominantReligion { get; set; }

        [Required(ErrorMessage = "The Mission Flag is required")]
        [DisplayName("Mission Flag")]
        public string MissionFlag { get; set; }
    }
}