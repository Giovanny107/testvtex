using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Movies
    {
        [Key]
        public int IdMovie { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdType { get; set; }
        public Types Types { get; set; }
        public int Year { get; set; }
        public int IdCompany { get; set; }
        public Companies Companies { get; set; }

        public ICollection<ActorsXMovie> ActorsXMovie { get; set; }
    }
}
