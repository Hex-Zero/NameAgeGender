using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NameAgeGender.Models;

namespace NameAgeGender.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly NameAgeGender.Models.PersonInfoDBcontext _context;

        public IndexModel(NameAgeGender.Models.PersonInfoDBcontext context)
        {
            _context = context;
        }

        public IList<PersonModel> PersonModel { get;set; }

        public async Task OnGetAsync()
        {
            PersonModel = await _context.Persons.ToListAsync();
        }
    }
}
