using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            Course c = new Course { Title = "ASP.NET MVC", Fee = 3000, Duration = 15 };
            return View(c);
        }

        public ActionResult List()
        {
            var courses = new List<Course>()
            {
                 new Course { Title = "ASP.NET MVC", Fee = 3000, Duration = 25 },
                 new Course { Title = "Angular", Fee = 2000, Duration = 15 },
                 new Course { Title = "Python", Fee = 5000, Duration = 40 }
            };

            return View(courses);
        }
    }
}