using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entitites;
using WebApplication.Models;

namespace WebApplication
{
    public class CrudContext:DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //_ = modelBuilder.Entity<Product>().HasData(new Product
            //{
                
            //    ProductName = "Bob",
            //    Category = "Ross",
            //    Cost = 90,
            //    ActiveInActive = true,
            //    Description = "string"
            //}, new ProductCategory
            //{
            //    AuthorId = Guid.NewGuid(),
            //    FirstName = "David",
            //    LastName = "Miller",
            //    Genre = "Fantasy"
            //});
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
