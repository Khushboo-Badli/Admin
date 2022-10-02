using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_page.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Meal Monkey";
            return View();
        }

        //public ActionResult About()            
       //    return View();
        

        //public ActionResult Contact()
        //{
          //  ViewBag.Message = "Your contact page.";

            //return View();
        //}

        
    }
}