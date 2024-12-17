using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationExample_16_VM.Models;

namespace WebApplicationExample_16_VM.DAL
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