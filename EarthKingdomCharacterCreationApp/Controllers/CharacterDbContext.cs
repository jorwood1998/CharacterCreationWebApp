using EarthKingdomCharacterCreationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Controllers
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext()
            : base("DefaultConnection") { }

        public DbSet<CharacterCreate> Characters { get; set; }
        public DbSet<Appearance> Appearance { get; set; }
        public DbSet<Attribute> Attribute {get; set;}

    }
}