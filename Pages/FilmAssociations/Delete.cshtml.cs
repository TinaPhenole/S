using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Pages.FilmAssociations
{
    public class DeleteModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public DeleteModel(SFF_Komplettering.Data.SFFDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FilmAssociation = await _context.FilmAssociation.FindAsync(id);

            if (FilmAssociation != null)
            {
                _context.FilmAssociation.Remove(FilmAssociation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
