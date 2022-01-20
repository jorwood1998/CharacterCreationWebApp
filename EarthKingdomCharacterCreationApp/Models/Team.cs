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
        public List<CharacterCreate> TeamMembers { get; set;} = new List<CharacterCreate>();
        //public Team() { }
        //public Team (string teamName, List<CharacterCreate> characterList)
        //{
        //    TeamName = teamName;
        //    TeamMembers = new List<CharacterCreate>();
        //    TeamMembers = characterList;
        //}


    }
}