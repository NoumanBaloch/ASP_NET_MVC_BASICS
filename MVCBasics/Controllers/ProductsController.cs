using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index()
        {
            return "I am on Product Page";
        }
    }
}