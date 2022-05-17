using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Pages.Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public DetailsModel(SFF_Komplettering.Data.SFFDbContext context)
        {
            _context = context;
        }

        public Review Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Review = await _context.Review.FirstOrDefaultAsync(m => m.Id == id);

            if (Review == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
