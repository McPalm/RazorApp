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
    public class IndexModel : PageModel
    {
        private readonly RazorApp.Models.RazorAppContext _context;

        public IndexModel(RazorApp.Models.RazorAppContext context)
        {
            _context = context;
        }

        public IList<RazorApp.Armor> Armor { get;set; }

        public async Task OnGetAsync()
        {
            Armor = await _context.Armor.ToListAsync();
        }
    }
}
