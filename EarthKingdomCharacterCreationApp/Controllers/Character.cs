﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Controllers
{
    public class Character
    {
        [Required]
        public string Name { get; set; }
    }
}