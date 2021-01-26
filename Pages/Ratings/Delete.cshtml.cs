using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Ratings
{
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DeleteModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rating Rating { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rating = await _context.Rating.FirstOrDefaultAsync(m => m.RatingId == id);

            if (Rating == null)
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

            Rating = await _context.Rating.FindAsync(id);

            if (Rating != null)
            {
                _context.Rating.Remove(Rating);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
