using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Customer_Reviews
{
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DeleteModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer_Review Customer_Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_Review = await _context.Customer_Review
                .Include(c => c.Customer)
                .Include(c => c.Movie).FirstOrDefaultAsync(m => m.Customer_ReviewId == id);

            if (Customer_Review == null)
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

            Customer_Review = await _context.Customer_Review.FindAsync(id);

            if (Customer_Review != null)
            {
                _context.Customer_Review.Remove(Customer_Review);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
