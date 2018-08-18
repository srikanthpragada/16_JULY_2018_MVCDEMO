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
        Dictionary<string,string> users = new Dictionary<string, string>
        {
            {"admin","admin" },
            {"user","user" },
            {"guest","guest"}
        };


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password, string ReturnUrl)
        {
            if (users.ContainsKey(user) && password == users[user])
            {
                FormsAuthentication.SetAuthCookie(user, false);
                HttpContext.Session.Add("user", user);
                HttpContext.Session.Add("loggedat",DateTime.Now);

                //HttpCookie c = new HttpCookie("city", "vizag");
                //HttpContext.Response.Cookies.Add(c);

                return RedirectToAction("../" + ReturnUrl);
            }
            else
                ViewBag.Message = "Invalid Login!";

            return View();
        }

        [Authorize]
        public ActionResult Home()
        {
            return View();
        }
    }
}

