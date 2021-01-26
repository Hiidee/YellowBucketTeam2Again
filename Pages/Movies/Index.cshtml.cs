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

namespace YellowBucket.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public IndexModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        // Genre Definitions
        [BindProperty]
        public int SelectedGenreId { set; get; }

        public List<SelectListItem> GenreItems { set; get; }

        // Ratings Definitions
        [BindProperty]
        public int SelectedRatingId { set; get; }

        public List<SelectListItem> RatingItems { set; get; }


        public async Task OnGetAsync()
        {

            Movie = await _context.Movie
                .Include(m => m.Rating)
                .Include(movie => movie.Genre)                
                .ToListAsync();

            int i = 1;
        }
    }
}
