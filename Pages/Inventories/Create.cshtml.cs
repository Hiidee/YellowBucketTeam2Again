using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Inventories
{
    public class CreateModel : PageModel
    {
        private readonly YellowBucket.Data.YellowBucketContext _context;

        public CreateModel(YellowBucket.Data.YellowBucketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["KioskId"] = new SelectList(_context.Kiosk, "KioskId", "KioskId");
        ViewData["MovieId"] = new SelectList(_context.Movie, "MovieId", "MovieId");
            return Page();
        }

        [BindProperty]
        public Inventory Inventory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inventory.Add(Inventory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
