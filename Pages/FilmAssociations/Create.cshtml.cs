using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Pages.FilmAssociations
{
    public class CreateModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public CreateModel(SFF_Komplettering.Data.SFFDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FilmAssociation FilmAssociation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FilmAssociation.Add(FilmAssociation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
