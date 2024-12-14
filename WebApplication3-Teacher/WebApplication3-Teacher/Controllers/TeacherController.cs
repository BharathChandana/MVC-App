using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_Teacher.DAL;
using WebApplication3_Teacher.Models;

namespace WebApplication3_Teacher.Controllers
{
    public class TeacherController : Controller
    {
        TeacherContext context = null;
        public TeacherController()
        {
            context = new TeacherContext();
        }
        // GET: Teacher
        public ActionResult Index()
        {
            List<Teacher> tlist = context.teachers.ToList();
            return View(tlist);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher t)
        {
            if(ModelState.IsValid)
            {
                context.teachers.Add(t);
                context.SaveChanges();
                List<Teacher> tlist=context.teachers.ToList();
                return View("Index",tlist);
            }
            return View("Create", t);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Teacher t=context.teachers.Find(Id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Edit(Teacher t)
        {
            if (ModelState.IsValid)
            {
                Teacher x= context.teachers.Find(t.TeacherId);
                x.TeacherName = t.TeacherName;
                x.TeacherSubject= t.TeacherSubject;
                x.TeacherSalary= t.TeacherSalary;
                context.SaveChanges();
                List<Teacher> tlist=context.teachers.ToList();
                return View("Index",tlist);
            }
            return View("Edit",t);
        }

        public ActionResult Details(int Id)
        {
            Teacher t = context.teachers.Find(Id);
            return View(t);
        }

        public ActionResult Delete(int Id)
        {
            Teacher t = context.teachers.Find(Id);
            context.teachers.Remove(t);
            context.SaveChanges();
            List<Teacher> tlist= context.teachers.ToList();
            return View("Index",tlist);
        }
    }
}