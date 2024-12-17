using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationExample14.Models;

namespace WebApplicationExample14.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult EnterNewProduct()
        {
            return View();
        }
        public ActionResult SaveProduct(Product p)
        {
            //Product p=new Product();
            //p.ProductId = int.Parse(Request.QueryString["ProductId"]);
            //p.ProductName = Request.QueryString["ProductName"];
            //p.Quantity = Request.QueryString["Quantity"];
            //p.Price = int.Parse(Request.QueryString["Price"]);
            return View("DisplayProduct",p);
        }
    }
}