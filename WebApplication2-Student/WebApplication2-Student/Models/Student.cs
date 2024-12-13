using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2_Student.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set;}

        [Required]
        public string StudentName { get; set;}

        [Required]
        public string StudentClass {  get; set;}

        [Required]
        public int StudentAge { get; set;}

    }
}