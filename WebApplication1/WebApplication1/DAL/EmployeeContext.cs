using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("name=EmployeeContext")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("EmployeeT");
        }
        public DbSet<Employee> employees { get; set; }

    }
}