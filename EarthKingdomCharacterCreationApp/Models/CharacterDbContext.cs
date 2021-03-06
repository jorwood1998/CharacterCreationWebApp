using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext()
            : base("DefaultConnection") { }
        public DbSet<CharacterCreate> CharacterCreate { get; set; }
        public DbSet<Appearance> Appearance { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public static CharacterDbContext Create()
        {
            return new CharacterDbContext();
        }

        public DbSet<Team> Team { get; set; }

    }
}