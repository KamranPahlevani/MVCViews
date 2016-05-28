using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Views.Infrastructure.Products;
using Views.Models;

namespace Views.Controllers
{
    public class WebGridHelperController : Controller
    {
        //
        // GET: /WebGridHelper/

        public ActionResult CreateWebGrid()
        {
            IEnumerable<Product> productList = new ProductList().GetProductsList();
            ViewBag.WebGrid = new WebGrid(source:productList, rowsPerPage:4);
            return View(productList);
        }



    }
}
