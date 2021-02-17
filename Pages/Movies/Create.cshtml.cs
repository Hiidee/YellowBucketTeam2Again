using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket.Models;

namespace YellowBucket.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public CreateModel(YellowBucket.Data.YellowBucketContext context, IWebHostEnvironment environment)
        {
            _context = context;

            _environment = environment;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // Genre Definitions
        [BindProperty]
        public int SelectedGenreId { set; get; }

        public List<SelectListItem> GenreItems { set; get; }

        // Ratings Definitions
        [BindProperty]
        public int SelectedRatingId { set; get; }

        public List<SelectListItem> RatingItems { set; get; }

        //Reviews Definitions
        [BindProperty]
        public int SelectedReviewId { get; set; }

        public List<SelectListItem> ReviewItems { get; set; }

        private IWebHostEnvironment _environment;
        //public CreateModel(IWebHostEnvironment environment)
        //{
        //    _environment = environment;
        //}

        [BindProperty]
        public IFormFile UploadedImage { get; set; }

        public IActionResult OnGet()
        {
            // Get the list of Genres from the Genre Model           
            GenreItems = _context.Genre
                                .Select(a => new SelectListItem
                                {
                                    Value = a.GenreId.ToString(),
                                    Text = a.Name
                                })
                               .ToList();

            // Get the list of Ratings from the Rating Model           
           RatingItems = _context.Rating
                                .Select(a => new SelectListItem
                                {
                                    Value = a.RatingId.ToString(),
                                    Text = a.Name
                                })
                               .ToList();

            // Get the List of Reviews from the Review Model ////////
            ReviewItems = _context.Review
                                .Select(a => new SelectListItem
                                 {
                                    Value = a.ReviewId.ToString(),
                                    Text = a.Name
                                 })
                                .ToList();

            return Page();
        }
      

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the file upload

            Console.WriteLine(UploadedImage.FileName);
            Console.WriteLine(_environment.ContentRootPath);

            var file = Path.Combine(_environment.ContentRootPath, "wwwroot/uploads", UploadedImage.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await UploadedImage.CopyToAsync(fileStream);
            }

            // Set the GenreId and RatingId //and ReviewId// to the input values
            Movie.Cover_Photo = UploadedImage.FileName;
            Movie.GenreId = this.SelectedGenreId;
            Movie.RatingId = this.SelectedRatingId;

            // Save the model
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
