﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Actors
    {
        [Key]
        public int IdActor { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<ActorsXMovie> ActorsXMovie { get; set; }
    }
}
