using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man", 
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue.... if spiderman survives <strong>Will Peter parker survive???</strong></p>", 
                Artists = new Artist[]
                {
                    new Artist(){Name = "Dant Slott", Role = "Script"},
                    new Artist(){Name = "Humberto Ramos", Role = "Pencil"},
                    new Artist(){Name = "Victor Olazaba", Role = "Inks"},
                    new Artist(){Name = "Edgar Delgado", Role = "Colors"},
                    new Artist(){Name = "Chris Eliopoulos", Role = "Letters"}
                }
            };

            return View(comicBook);
        }
    }
}