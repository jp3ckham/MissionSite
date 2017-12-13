using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MissionSite2.DAL
{
    public class MissionSite2Context : DbContext
    {

        public MissionSite2Context() : base("MissionSite2Context")
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionQuestions> MissionQuestion { get; set; } 
    }
}