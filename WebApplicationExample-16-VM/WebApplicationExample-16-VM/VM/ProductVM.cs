using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationExample_16_VM.Models;

namespace WebApplicationExample_16_VM.VM
{
    public class ProductVM
    {
        public Product p {  get; set; }
        public List<Product> products { get; set; }
    }
}