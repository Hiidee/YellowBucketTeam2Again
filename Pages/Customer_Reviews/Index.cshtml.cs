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
    public class IndexModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public IndexModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public IList<Customer_Review> Customer_Review { get;set; }

        public async Task OnGetAsync()
        {
            Customer_Review = await _context.Customer_Review
                .Include(c => c.Customer)
                .Include(c => c.Movie).ToListAsync();
        }
    }
}
