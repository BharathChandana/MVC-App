using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_Teacher2.Context;
using WebApplication3_Teacher2.Models;

namespace WebApplication3_Teacher2.Controllers
{
    public class TController : Controller
    {
        TContext context = null;
        public TController()
        {
            context = new TContext();
        }
        // GET: T2
        public ActionResult Index()
        {
            List<Teacher> t2list=context.teachers.ToList();
            return View(t2list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher t)
        {
            if (ModelState.IsValid)
            {
                context.teachers.Add(t);
                context.SaveChanges();
                List<Teacher> tlist = context.teachers.ToList();
                return View("Index",tlist);
            }
            return View("Create", t);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Teacher t = context.teachers.Find(Id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Edit(Teacher t)
        {
            if (ModelState.IsValid)
            {
                Teacher x = context.teachers.Find(t.TId);
                x.TName = t.TName;
                x.TRole=t.TRole;
                x.TSalary=t.TSalary;
                context.SaveChanges();
                return View("Index", context.teachers.ToList());
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
            List<Teacher> tlist=context.teachers.ToList();
            return View("Index",tlist);
        }
    }
}