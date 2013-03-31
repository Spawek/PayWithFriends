using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using PayWithFriends.Models;

namespace PayWithFriends.Controllers
{

    //SOME TUTORIALS: http://blue-and-orange.net/articles/facebook/integrating-facebook-login-button-in-aspnet-mvc-4-application/
    //http://blue-and-orange.net/articles/facebook/integrating-facebook-login-button-in-aspnet-mvc-4-application/

    public class FacebookLogin : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            var accessToken = context.Request["accessToken"];
            context.Session["AccessToken"] = accessToken;

            context.Response.Redirect("/Home");
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }



    public class TestController : Controller
    {

        DbClassesDataContext db = new DbClassesDataContext();
        FacebookClient client = new FacebookClient();
        FacebookLogin FbLogin = new FacebookLogin();

        //
        // GET: /Test/
        

        public ActionResult Index()
        {
            //var data = from r in db.Friends
            //           select r;
            //return View(data);
            //client.AccessToken = 

            ///NEW
            //var accessToken = Session["AccessToken"].ToString();
            //var client = new FacebookClient(accessToken);

            //dynamic me = client.Get("me") as IDictionary<string, object>;
            //return View(me);

            return View();
        }

        //
        // GET: /Test/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Test/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Test/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Test/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Test/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Test/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Test/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
