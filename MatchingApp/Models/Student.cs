using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchingApp.Models
{
    public class Student : BaseEntity
    {
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        public Application application { get; set; }

        [MaxLength(32)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(32)]
        [Required]
        public double GPDA { get; set; }

        [MaxLength(32)]
        [Required]
        public string ZajelId { get; set; }

        [Required]
        public int NumberOfHourse { get; set; }
    
        [Required]
        public bool Toofel { get; set; }
  
        [Required]
        public char Gender { get; set; }

        
    }
}
