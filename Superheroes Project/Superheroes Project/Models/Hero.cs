using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes_Project.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public int firstName { get; set; }
        public int lastName { get; set; }
    }
}