using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFakture.Models
{
    // this manages the onnection to the database
    public class Northwind : DbContext
    {
        //these properties map to tables in the database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public Northwind(DbContextOptions<Northwind> options)
                        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // example to using Fluent API instead of attributes
            // to limit the length of a category name to under 40 
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);

        }


    }
}
