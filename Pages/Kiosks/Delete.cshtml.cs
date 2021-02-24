using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Kiosks
{
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public DeleteModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kiosk Kiosk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kiosk = await _context.Kiosk.FirstOrDefaultAsync(m => m.KioskId == id);

            if (Kiosk == null)
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

            Kiosk = await _context.Kiosk.FindAsync(id);

            if (Kiosk != null)
            {
                _context.Kiosk.Remove(Kiosk);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
