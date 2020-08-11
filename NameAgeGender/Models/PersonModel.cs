using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameAgeGender.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
