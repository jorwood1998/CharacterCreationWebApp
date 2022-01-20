using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Models
{
    public class TeamDBContext : DbContext
    {
        public TeamDBContext()
            : base("Default Connection") { }

        public DbSet<Team> Team { get; set;}
    }
}