﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite2.Models
{
    //This is the mission questions model
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int MissionQuestionID { get; set; }

        [ForeignKey("Mission")]
        [Required(ErrorMessage = "The Mission ID is required")]
        public int MissionID { get; set; }
        public virtual Mission Mission { get; set; }

        [ForeignKey("Users")]
        public string UserEmail { get; set; }
        public virtual Users Users { get; set; }

        [Required(ErrorMessage = "The Question  is required")]
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}