using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Pages.Rentals
{
    public class DeleteModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public DeleteModel(SFF_Komplettering.Data.SFFDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rental Rental { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rental = await _context.Rental.FirstOrDefaultAsync(m => m.Id == id);

            if (Rental == null)
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

            Rental = await _context.Rental.FindAsync(id);

            if (Rental != null)
            {
                _context.Rental.Remove(Rental);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
