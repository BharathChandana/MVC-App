using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3_Teacher2.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TId { get; set; }

        [Required]
        public string TName { get; set; }

        [Required]
        public string TRole {  get; set; }

        [Required]
        public decimal TSalary {  get; set; }

    }
}