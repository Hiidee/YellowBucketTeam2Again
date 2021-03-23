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
    public class IndexModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public IndexModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public IList<Wishlist> Wishlist { get;set; }

        public async Task OnGetAsync()
        {
            Wishlist = await _context.Wishlist
                .Include(w => w.Customer)
                .Include(w => w.Movie).ToListAsync();
        }
    }
}
