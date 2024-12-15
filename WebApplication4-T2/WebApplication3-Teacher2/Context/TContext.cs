using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3_Teacher2.Models;

namespace WebApplication3_Teacher2.Context
{
    public class TContext:DbContext
    {
        public TContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().ToTable("Tt");
        }
        public DbSet<Teacher> teachers { get; set; }
    }
}