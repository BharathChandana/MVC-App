using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationExampless.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewData["v1"] = "I am v1 created inside Index using ViewData";
            ViewBag.v2 = "I am v2 creted inside Index using ViewBag";
            TempData["v3"] = "I am v3 created inside Index using TempData";
            Session["v4"] = "I am v4 created inside Index using Session";
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            ViewData["v1"] = ViewData["v1"] + "Inside Display";
            ViewBag.v2 = ViewBag.v2 + "Inside Display";
            TempData["v3"] = TempData["v3"] + "Inside Display";
            Session["v4"]= Session["v4"]+"Inside Display";
            return View();
        }
    }
}