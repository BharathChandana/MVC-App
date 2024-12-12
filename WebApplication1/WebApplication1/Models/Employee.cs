using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId {  get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public int EmployeeAge { get; set; }

        [Required]
        public string EmployeeRole {  get; set; }

        [Required]
        public decimal EmployeeSalary {  get; set; }

    }
}