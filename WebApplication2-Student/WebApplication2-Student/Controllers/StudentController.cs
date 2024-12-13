using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2_Student.DAL;
using WebApplication2_Student.Models;

namespace WebApplication2_Student.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = null;
        public StudentController()
        {
            context= new StudentContext();
        }
        // GET: Student
        public ActionResult Index()
        {
            List<Student> slist=context.students.ToList();
            return View(slist);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                context.students.Add(s);
                context.SaveChanges();
                List<Student> slist= context.students.ToList();
                return View("Index",slist);
            }
            return View("Create",s);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Student s = context.students.Find(Id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if(ModelState.IsValid)
            {
                Student x = context.students.Find(s.StudentId);
                x.StudentName=s.StudentName;
                x.StudentClass=s.StudentClass;
                x.StudentAge=s.StudentAge;
                context.SaveChanges();
                return View("Index",context.students.ToList());
            }
            return View("Edit",s);
        }

        public ActionResult Details(int Id)
        {
            Student s=context.students.Find(Id) ;
            return View(s);
        }

        public ActionResult Delete(int Id)
        {
            Student s= context.students.Find(Id) ;
            context.students.Remove(s);
            context.SaveChanges() ;
            List<Student> slist=context.students.ToList();
            return View("Index",slist);
        }
    }
}