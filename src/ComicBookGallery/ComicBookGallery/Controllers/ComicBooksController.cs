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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");    // metodo de la clase controller que reemplaza a new RedirectResult("/");
            }

            return Content("Hello from the comic books controller");

            // ^ metodo de la clase controller que reemplaza a v
            /*
            return new ContentResult()
            {
                Content = "Hello from the comic books controller"
            };
            */
        }
    }
}