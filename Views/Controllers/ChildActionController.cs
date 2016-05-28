using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class ChildActionController : Controller
    {
        //
        // GET: /ChildAction/

        [ChildActionOnly]
        public ActionResult ChildAction(DateTime time)
        {
            return PartialView(time);
        }

        public ActionResult ChildActionUse()
        {
            return View();
        }

    }
}
