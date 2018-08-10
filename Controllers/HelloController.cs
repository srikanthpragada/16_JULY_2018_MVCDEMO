using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HelloController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Today = DateTime.Now.ToString("dd-MM-yyyy");
            return View();
        }

        public string Wish(string user)
        {
            if (user == null)
                user = "World!";

            return "Good Morning " + user;
        }

        public ActionResult Greet(string user, string color="red")
        {
            if (user == null || user == "")
                user = "World!";

            var hour = DateTime.Now.Hour;
            var msg = "";

            if (hour < 12)
                msg = "Good Morning";
            else
                if (hour < 18)
                msg = "Good Afternoon";
            else
                msg = "Good Evening";

            ViewBag.Message = msg + " " +  user;
            ViewBag.Color = color;
            return View();
        }
    }
}