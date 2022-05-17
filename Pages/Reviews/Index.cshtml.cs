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
    public class IndexModel : PageModel
    {
        private readonly SFF_Komplettering.Data.SFFDbContext _context;

        public IndexModel(SFF_Komplettering.Data.SFFDbContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; }

        public async Task OnGetAsync()
        {
            Review = await _context.Review.ToListAsync();
        }
    }
}
