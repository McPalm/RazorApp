using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorApp;
using RazorApp.Models;

namespace RazorApp.Pages.Armor
{
    public class CreateModel : PageModel
    {
        private readonly RazorApp.Models.RazorAppContext _context;

        public CreateModel(RazorApp.Models.RazorAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RazorApp.Armor Armor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Armor.Add(Armor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}