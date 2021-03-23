using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Rental
{
    public class DetailsModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DetailsModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public Rentals Rentals { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rentals = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Inventory).FirstOrDefaultAsync(m => m.RentalsId == id);

            if (Rentals == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
