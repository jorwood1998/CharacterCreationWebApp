using EarthKingdomCharacterCreationApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }    
        public List<CharacterClass> TeamMembers { get; set;} = new List<CharacterClass>();
        public Team() { }
        public Team (string teamName, List<CharacterClass> characterList)
        {
            TeamName = teamName;
            TeamMembers = new List<CharacterClass>();
            TeamMembers = characterList;
        }


    }
}