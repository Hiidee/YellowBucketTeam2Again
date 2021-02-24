using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.WishList
{
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DeleteModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Wishlist Wishlist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wishlist = await _context.Wishlist
                .Include(w => w.Customer)
                .Include(w => w.Movie).FirstOrDefaultAsync(m => m.WishlistId == id);

            if (Wishlist == null)
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

            Wishlist = await _context.Wishlist.FindAsync(id);

            if (Wishlist != null)
            {
                _context.Wishlist.Remove(Wishlist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
