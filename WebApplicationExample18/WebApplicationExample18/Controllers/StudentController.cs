using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplicationExample18.Models;
using WebApplicationExample18.VM;

namespace WebApplicationExample18.Controllers
{
    public class StudentController : Controller
    {
        
        // GET: Student
        public ActionResult Index()
        {
            
            Student s = new Student()
            {
                StudentId = 1,
                StudentName = "Bharath",
                NameOfExam = "Final",
                Standard = "10th",
                s1 = 91,
                s2=83,
                s3=78,
                s4=59,
                s5=68,
                s6=57
            };
            StudentVM svm=new StudentVM(s);
            return View(svm);
        }

        
    }
}