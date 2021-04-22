using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Types
    {
        [Key]
        public int IdType { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }
}
