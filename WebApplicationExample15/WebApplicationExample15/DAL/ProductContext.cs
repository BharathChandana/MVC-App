using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationExample15.Models;

namespace WebApplicationExample15.DAL
{
    public class ProductContext:DbContext
    {
        public ProductContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
        }
        public DbSet<Product> products { get; set; }
    }
}