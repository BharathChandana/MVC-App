using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3_Teacher.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeacherId { get; set; }

        [Required]
        public string TeacherName { get; set; }

        [Required]
        public string TeacherSubject { get;set; }

        [Required]
        public decimal TeacherSalary { get; set; }
    }
}