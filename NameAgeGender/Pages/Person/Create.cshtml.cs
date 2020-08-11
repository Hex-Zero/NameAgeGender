using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NameAgeGender.Models;

namespace NameAgeGender.Pages.Person
{
    public class CreateModel : PageModel
    {
        private readonly NameAgeGender.Models.PersonInfoDBcontext _context;

        public CreateModel(NameAgeGender.Models.PersonInfoDBcontext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PersonModel PersonModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Persons.Add(PersonModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
