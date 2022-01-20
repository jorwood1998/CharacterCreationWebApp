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
        public List<Character> TeamMembers { get; set;} = new List<Character>();
        public Team() { }
        public Team (string teamName, List<Character> characterList)
        {
            TeamName = teamName;
            TeamMembers = new List<Character>();
            TeamMembers = characterList;
        }


    }
}