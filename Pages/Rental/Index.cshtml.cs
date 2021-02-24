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
    public class IndexModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public IndexModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public IList<Rentals> Rentals { get;set; }

        public async Task OnGetAsync()
        {
            Rentals = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Inventory).ToListAsync();
        }
    }
}
