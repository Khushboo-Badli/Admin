using Admin_page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_page.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: LoginAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(MM_Admin admin)
        {
            using (Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
            {
                try
                {
                    var login_admin = adb.MM_Admin.Single(u => u.Username == "Admin" && u.Password == "Admin123");
                    if (login_admin != null)
                    {
                        Session["Username"] = login_admin.Username.ToString();
                        Session["Password"] = login_admin.Password.ToString();
                        //return View();
                         return RedirectToAction("Index", "Home");

                    }

                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Username or Password is incorrect");

                    ///throw;
                }
            }
            return View();
        }
    }
}