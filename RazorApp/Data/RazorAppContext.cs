using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorApp;

namespace RazorApp.Models
{
    public class RazorAppContext : DbContext
    {
        public RazorAppContext (DbContextOptions<RazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorApp.Armor> Armor { get; set; }
    }
}
