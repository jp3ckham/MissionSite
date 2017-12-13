using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MissionSite2.Models
{
    public class MissionQuestions
    {
        [Key]
        public int MissionQuestionID { get; set; }

        [Required(ErrorMessage = "The Mission ID is required")]
        public int MissionID { get; set; }

        [Required(ErrorMessage = "The User ID  is required")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "The Question  is required")]
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}