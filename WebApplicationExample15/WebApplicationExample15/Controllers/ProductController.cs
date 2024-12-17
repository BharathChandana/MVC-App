using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationExample15.DAL;
using WebApplicationExample15.Models;

namespace WebApplicationExample15.Controllers
{
    public class ProductController : Controller
    {
        ProductContext dal;
        public ProductController()
        {
            dal= new ProductContext();
        }
        // GET: Product
        public ActionResult EnterNewProduct()
        {
            Product p = new Product();
            return View(p);
        }
        public ActionResult SaveProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                dal.products.Add(p);
                dal.SaveChanges();
                List<Product> plist=dal.products.ToList();
                return View("ListProducts", plist);
            }
            else
            {
                return View("EnterNewProduct", p);
            }
        }
    }
}