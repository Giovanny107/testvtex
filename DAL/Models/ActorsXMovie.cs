using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class ActorsXMovie
    {
        [Key]
        public int IdActorXMovie { get; set; }
        public int IdActor { get; set; }
        public int IdMovie { get; set; }

        public Actors Actors { get; set; }
        public Movies Movies { get; set; }
    }
}
