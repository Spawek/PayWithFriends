using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayWithFriends.Models;

namespace PayWithFriends.Controllers
{
    public class HomeController : Controller
    {
        private DbClassesDataContext db = new DbClassesDataContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var data = from r in db.Friends
                       orderby r.senderID ascending
                       select r;

            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(db != null)
            {
                db.Dispose();
            }
 	        base.Dispose(disposing);
        }
    }
}
