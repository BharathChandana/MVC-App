using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationExample_16_VM.DAL;
using WebApplicationExample_16_VM.Models;
using WebApplicationExample_16_VM.VM;

namespace WebApplicationExample_16_VM.Controllers
{
    public class ProductController : Controller
    {
        ProductContext dal;
        public ProductController()
        {
            dal=new ProductContext();
        }
        // GET: Product
        public ActionResult EnterNewProduct()
        {
            ProductVM pvm = new ProductVM();
            pvm.p= new Product();
            pvm.products= dal.products.ToList();
            return View(pvm);
        }
        public ActionResult SaveProduct(Product p)
        {
            ProductVM pvm = new ProductVM();
            if(ModelState.IsValid)
            {
                dal.products.Add(p);
                dal.SaveChanges();
                List<Product> plist = dal.products.ToList();
                pvm.p = new Product();
                pvm.products= plist;
                return View("EnterNewProduct", pvm);
            }
            else
            {
                pvm.p = p;
                pvm.products = dal.products.ToList();
                return View("EnterNewProduct", pvm);
            }
        }
    }
}