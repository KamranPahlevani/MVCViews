using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Infrastructure.CustomHtmlHelpers;

namespace Views.Controllers
{
    public class CustomHtmlHelperController : Controller
    {
        //
        // GET: /CustomHtmlHelper/

        public ActionResult CreateCustomHtmlHelper()
        {
            string[] Days = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Days[i] = Enum.GetNames(typeof(DayOfWeek))[i];
            }
            string[] Fruits = new string[]{
                "Apple",
                "Mango",
                "Banana"
            };
            ViewBag.Days = Days;
            ViewBag.Fruits = Fruits;
            return View();
        }

    }
}
