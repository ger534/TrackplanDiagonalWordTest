using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackplanDiagonalWordTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WordTable()
        {
            var uri = new Uri(Request.Url.ToString());

            try {
                ViewBag.word = uri.Segments[2];
            } catch (Exception) {
                ViewBag.word = "";
            }
            
            return View();
        }
    }
}