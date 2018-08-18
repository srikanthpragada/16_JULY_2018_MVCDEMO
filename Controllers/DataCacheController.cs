using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class DataCacheController : Controller
    {
        
        public string Index()
        {
            string message, today = null;
            // Check whether there is any object called today

            if (HttpContext.Cache["today"] == null) // key not found, so create it
            {
                today = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                createCache(today);
                message = "Creating cache!";
            }
            else  // found key, so use it
            {
                today = HttpContext.Cache["today"].ToString();
                message = "Using cache!";
            }
            return "<h2>" + today + "</h2><h3>" + message + "</h3>";
        }

        public string  List()
        {
            string message, today = null;
            // Check whether there is any object called today

            if (HttpContext.Cache["today"] == null)
            {
                today = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                createCache(today);
                message = "Creating cache!";
            }
            else
            {
                today = HttpContext.Cache["today"].ToString();
                message = "Using cache!";
            }

            return "<h1>" + today + "</h1><h3>" + message + "</h3>";
        }

        private void createCache(string today)
        {
            HttpContext.Cache.Add("today",
                   today,
                   null,
                   DateTime.Now.AddMinutes(2),   // Expired after two mins 
                   TimeSpan.Zero,
                   System.Web.Caching.CacheItemPriority.Default,
                   null);
        }
    }
}