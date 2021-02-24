using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket.Data;
using YellowBucket.Models;

namespace YellowBucket.Pages.Rental
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
        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
        ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId");
            return Page();
        }

        [BindProperty]
        public Rentals Rentals { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rentals.Add(Rentals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
