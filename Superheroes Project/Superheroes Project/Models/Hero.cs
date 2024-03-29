﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes_Project.Models
{
    public class Hero
    {
        [Key]
        public int HeroId { get; set; }
        public string SuperheroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}