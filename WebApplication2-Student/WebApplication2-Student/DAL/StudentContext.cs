using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2_Student.Models;

namespace WebApplication2_Student.DAL
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("name=StudentContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("StudentT");
        }
        public DbSet<Student>students { get; set; }
    }
}