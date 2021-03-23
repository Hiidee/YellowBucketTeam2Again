using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.WishList
{
    public class EditModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public EditModel(YellowBucket.Data.YellowBucketContext context)
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
           ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
           ViewData["MovieId"] = new SelectList(_context.Movie, "MovieId", "MovieId");
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

            _context.Attach(Wishlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WishlistExists(Wishlist.WishlistId))
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

        private bool WishlistExists(int id)
        {
            return _context.Wishlist.Any(e => e.WishlistId == id);
        }
    }
}
