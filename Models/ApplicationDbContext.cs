using System;
using Microsoft.EntityFrameworkCore;
using WebSiteAssignment2.Models;

namespace WebSiteAssignment2.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Band> Bands { get; set; }
    }
}