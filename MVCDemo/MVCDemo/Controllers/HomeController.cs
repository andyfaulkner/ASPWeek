using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About(string myName = "", int myNumber = 1)
        {
            ViewBag.Message2 = "Hello" + myName + " you typed in the number " + myNumber;
            return View();
        }

        //getting a parameter via routing
        public ActionResult Contact(int id = 1)
        {
            ViewBag.AnotherMessage = "You have just enteredd the number " + id;
            return View();
        }
    }
}