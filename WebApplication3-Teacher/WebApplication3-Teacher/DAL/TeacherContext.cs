using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3_Teacher.Models;

namespace WebApplication3_Teacher.DAL
{
    public class TeacherContext:DbContext
    {
        public TeacherContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().ToTable("TeacherT");
        }
        public DbSet<Teacher> teachers { get; set; }
    }
}