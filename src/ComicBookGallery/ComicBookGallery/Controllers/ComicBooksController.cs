using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.UI.WebControls;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue.... if spiderman survives <strong>Will Peter parker survive???</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script : Dant Slott",
                "Pencil : Humberto Ramos",
                "Inks   : Victor Olazaba",
                "Colors : Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();
        }
    }
}