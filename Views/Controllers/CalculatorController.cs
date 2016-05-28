using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculate/

        public ActionResult Calculate()
        {
            ViewBag.X = 10;
            ViewBag.Y = 4;
            return View();
        }

    }
}
