using Hometask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hometask.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Test { get; set; }
    }
}
