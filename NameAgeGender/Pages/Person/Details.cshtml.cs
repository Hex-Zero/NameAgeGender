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
    public class DetailsModel : PageModel
    {
        private readonly NameAgeGender.Models.PersonInfoDBcontext _context;

        public DetailsModel(NameAgeGender.Models.PersonInfoDBcontext context)
        {
            _context = context;
        }

        public PersonModel PersonModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonModel = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);

            if (PersonModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
