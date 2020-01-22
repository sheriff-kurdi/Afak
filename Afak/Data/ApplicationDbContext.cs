using System;
using System.Collections.Generic;
using System.Text;
using Afak.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Afak.ViewModels;

namespace Afak.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //         => options.UseSqlite("Data Source=blogging.db");

        public DbSet<Product> Products { get; set; }
        public DbSet<Offer> Offers { get; set; }
 


    }
}
