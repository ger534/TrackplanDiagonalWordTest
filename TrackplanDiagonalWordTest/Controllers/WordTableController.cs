using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackplanDiagonalWordTest.Models;

namespace TrackplanDiagonalWordTest.Controllers
{
    public class WordTableController : Controller
    {
        [HttpPost]
        public ActionResult WordTable(WordModel wordModel)
        {
            return View(wordModel);
        }
    }
}