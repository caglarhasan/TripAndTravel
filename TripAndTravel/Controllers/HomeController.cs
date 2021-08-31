using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripAndTravel.Models;

namespace TripAndTravel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Test
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        
    }
}