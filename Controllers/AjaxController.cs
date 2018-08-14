using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public string Now()
        {
            return DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        public string Prodname(int id)
        {
            // Get name for id
            if (id < 10)
                return "Product " + id;
            else
                return null; 
        }
    }
}