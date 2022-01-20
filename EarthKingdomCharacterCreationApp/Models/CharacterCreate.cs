using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Models
{
    public class CharacterCreate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }

        [Required]
        public string Strength { get; set; }

        [Required]
        public string Dexterity { get; set; }

        [Required]
        public string Constitution { get; set; }

        [Required]
        public string Intelligence { get; set; }

        [Required]
        public string Wisdom { get; set; }
        
        [Required]
        public string Charisma { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Alias { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public string Build { get; set; }

        [Required]
        public string HairStyle { get; set; }

        [Required]
        public string HairColor { get; set; }

        [Required]
        public string EyeColor { get; set; }

        [Required]
        public string SkinColor { get; set; }

        [Required]
        public string SpecialItems { get; set; }
    }
}