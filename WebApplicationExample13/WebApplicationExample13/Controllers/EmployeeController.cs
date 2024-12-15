using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationExample13.Controllers
{
    public class EmployeeController:Controller
    {
        public ActionResult DisplayEmployees()
        {
            return View();
        }
    }
}