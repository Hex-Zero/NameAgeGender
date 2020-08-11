using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameAgeGender.Models
{
    public class PersonInfoDBcontext : DbContext
    {
        public PersonInfoDBcontext(DbContextOptions options): base(options) { }
        public DbSet<PersonModel> Persons { get; set; }
    }
}
