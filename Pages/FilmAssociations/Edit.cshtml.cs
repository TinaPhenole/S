using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Pages.FilmAssociations
{
    public class EditModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public EditModel(SFF_Komplettering.Data.SFFDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FilmAssociation FilmAssociation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FilmAssociation = await _context.FilmAssociation.FirstOrDefaultAsync(m => m.Id == id);

            if (FilmAssociation == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FilmAssociation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmAssociationExists(FilmAssociation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FilmAssociationExists(int id)
        {
            return _context.FilmAssociation.Any(e => e.Id == id);
        }
    }
}
