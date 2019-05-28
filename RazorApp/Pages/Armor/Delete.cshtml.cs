using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorApp;
using RazorApp.Models;

namespace RazorApp.Pages.Armor
{
    public class DeleteModel : PageModel
    {
        private readonly RazorApp.Models.RazorAppContext _context;

        public DeleteModel(RazorApp.Models.RazorAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RazorApp.Armor Armor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Armor = await _context.Armor.FirstOrDefaultAsync(m => m.Id == id);

            if (Armor == null)
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

            Armor = await _context.Armor.FindAsync(id);

            if (Armor != null)
            {
                _context.Armor.Remove(Armor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
