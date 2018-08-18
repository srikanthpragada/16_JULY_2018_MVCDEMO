using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            TempData["Message"] = "From Index";
            return RedirectToAction("Search");
        }

        public string Search()
        {
            return "Message : " + TempData["Message"];
        }



    }
}