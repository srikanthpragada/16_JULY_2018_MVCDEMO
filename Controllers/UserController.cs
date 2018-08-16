using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcDemo.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string password)
        {
            if (password == "admin")
            {
                FormsAuthentication.SetAuthCookie("admin", false);
                return RedirectToAction("../Products/Index");
            }
            else
                ViewBag.Message = "Invalid Login!";

            return View();
        }
    }
}

