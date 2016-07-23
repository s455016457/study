using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult UrlIsInvalid()
        {
            return View();
        }

    }
}
