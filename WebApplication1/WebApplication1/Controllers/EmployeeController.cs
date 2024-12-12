using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext context = null;
        public EmployeeController()
        {
            context=new EmployeeContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> elist=context.employees.ToList();
            return View(elist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                context.employees.Add(emp);
                context.SaveChanges();
                List<Employee> elist= context.employees.ToList();
                return View("Index",elist);
            }
            return View("Create",emp);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Employee emp = context.employees.Find(Id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if(ModelState.IsValid)
            {
                Employee x = context.employees.Find(emp.EmployeeId);
                x.EmployeeName= emp.EmployeeName;
                x.EmployeeRole= emp.EmployeeRole;
                x.EmployeeAge=emp.EmployeeAge;
                x.EmployeeSalary= emp.EmployeeSalary;
                context.SaveChanges();
                return View("Index", context.employees.ToList());

            }
            return View("Edit", emp);
        }
        public ActionResult Details(int Id)
        {
            Employee emp = context.employees.Find(Id);
            return View(emp);
        }
        public ActionResult Delete(int Id)
        {
            Employee emp=context.employees.Find(Id);
            context.employees.Remove(emp);
            context.SaveChanges();
            List<Employee> elist= context.employees.ToList();
            return View("Index", elist);
        }
    }
}