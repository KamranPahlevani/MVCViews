using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class PartialViewController : Controller
    {
        //
        // GET: /PartialView/

        public ActionResult PartialViewUse()
        {
            return View();
        }

    }
}
