using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchingApp.Models
{
    public class Application:BaseEntity
    {
        [MaxLength(32)]
        [Required]
        public string name { get; set; }

        [Required]
        public bool completed { get; set; }

        [Required]
        public ICollection<Student> Students { get; set; }

        public ICollection<Doctor> Doctors { get; set; }


    }
}
