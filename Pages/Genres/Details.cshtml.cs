using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Genres
{
    public class DetailsModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DetailsModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genre.FirstOrDefaultAsync(m => m.GenreId == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
