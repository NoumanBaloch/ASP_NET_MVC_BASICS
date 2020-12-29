using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.XYZ = "My First Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomer(Customer postedCustomer)
        {
            Customer customer = new Customer();
            customer.Id = Guid.NewGuid().ToString();
            customer.Name = postedCustomer.Name;
            customer.PhoneNumber = postedCustomer.PhoneNumber;
            return View(customer);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
    }
}