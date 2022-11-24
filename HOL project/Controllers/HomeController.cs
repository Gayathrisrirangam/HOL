using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;

namespace HOL_project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1> This is a demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1> This is a demo of ContentResult</h1>","text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1> This is a demo of ContentResult</h1>","text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1> This is a demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"h:\softwared.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"h:\softwared.jpg", "image/jpg",
           "capgemini.jpg");
        }
        public ActionResult Youtube()
        {
            return Redirect("https://www.youtube.com/results?search_query=asp.net+mvc+code+semantic");
        }
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "html" });
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}