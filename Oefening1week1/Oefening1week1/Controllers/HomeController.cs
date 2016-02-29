using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oefening1week1.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            var controller = RouteData.Values["Controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}:: {1} {2}", controller, action, id);

            return message;
        }

        public String About()
        {
            var controller = RouteData.Values["Controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}:: {1} {2}", controller, action, id);

            return message;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search(String genre = "Rock")
        {
            switch (genre.ToLower())
            {
                case "rock":
                    Response.Redirect("https://www.youtube.com/playlist?list=PLhd1HyMTk3f5yqcPXjLo8qroWJiMMFBSk");
                    break;

                case "jazz":
                    var message = Server.HtmlEncode(genre);
                    return RedirectToAction("Index", "Home", genre);

                case "metal":
                    return RedirectToRoute("About");

                case "classic":
                    return File(Server.MapPath("~/Content/Site.css"), "text/css");

                default:
                    var controller = RouteData.Values["Controller"];
                    var action = RouteData.Values["action"];
                    var id = RouteData.Values["id"];
                    var message2 = String.Format("{0}:: {1} {2}", controller, action, id);
                    return Content(message2);
                }
            return null;
        }

        public String Details()
        {
            var controller = RouteData.Values["Controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}:: {1} {2}", controller, action, id);

            return message;
        }
    }
}