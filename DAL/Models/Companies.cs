using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Companies
    {
        [Key]
        public int IdCompany { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }
}
