using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationExample17.Models;

namespace WebApplicationExample17.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student st = new Student()
            {
                StudentId = 1,
                Name="Bharath",
                Standard="10th",
                NameOfExam="Final",
                s1=90,
                s2=91,
                s3=89,
                s4=97,
                s5=99,
                s6=99
            };
            return View(st);
        }
    }
}