using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MissionSite2.Models
{
    public class Users
    {
        public int UserID { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage ="Please enter a valid password")]

        public string UserPassword { get; set; }

        [Required(ErrorMessage ="Please enter your first name")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string UserLastName { get; set; }



    }
}