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

        public ActionResult Helper()
        {
            return View();
        }

        public string  Interest(double amount, int months)
        {
            double interest;

            if (months <= 24)
                interest = amount * 0.10;
            else
                interest = amount * 0.12;

            return interest.ToString();
        }

        public ActionResult Table(int number)
        {
            return PartialView(number);
        }
    }
}