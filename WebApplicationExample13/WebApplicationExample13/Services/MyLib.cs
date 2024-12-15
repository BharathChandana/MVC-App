using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationExample13.Models;

namespace WebApplicationExample13.Services
{
    public class MyLib
    {
        public List<Employee> GetEmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name="Bharath",
                    Department="Solutions",
                    Designation="Developer",
                    Salary=200000
                },
                new Employee()
                {
                    Id=2,
                    Name="Kumar",
                    Department="Microsoft",
                    Designation="Tester",
                    Salary=30000
                }
            };
            return emplist;
        }
    }
}