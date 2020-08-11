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
    public class DeleteModel : PageModel
    {
        private readonly NameAgeGender.Models.PersonInfoDBcontext _context;

        public DeleteModel(NameAgeGender.Models.PersonInfoDBcontext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonModel = await _context.Persons.FindAsync(id);

            if (PersonModel != null)
            {
                _context.Persons.Remove(PersonModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
