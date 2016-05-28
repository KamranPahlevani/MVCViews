using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class MvcHtmlStringController : Controller
    {
        //
        // GET: /MvcHTMLString/

        public MvcHtmlString CreateMvcHTMLString()
        {
            return new MvcHtmlString("<form>Enter your password:<input type=text><input type=submit value=\"Log In\"></form>");
        }

    }
}
