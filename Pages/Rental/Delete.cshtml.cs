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
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DeleteModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rentals = await _context.Rentals.FindAsync(id);

            if (Rentals != null)
            {
                _context.Rentals.Remove(Rentals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
