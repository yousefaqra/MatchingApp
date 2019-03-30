using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchingApp.Models
{
    public class Doctor : BaseEntity
    {
        public string name { get; set; }
        public Application application { get; set; }
    }
}
