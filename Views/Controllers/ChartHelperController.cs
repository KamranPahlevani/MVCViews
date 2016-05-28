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
    public class ChartHelperController : Controller
    {
        //
        // GET: /ChartHelper/

        public ActionResult CreateChart()
        {
            IEnumerable<Product> productList = new ProductList().GetProductsList();

            Chart chart = new Chart(400, 200,
                                            @"<Chart BackColor=""Gray"" BackSecondaryColor=""WhiteSmoke""
                                                     BackGradientStyle=""DiagonalRight"" AntiAliasing=""All""
                                                     BorderlineDashStyle=""Solid"" BorderlineColor=""Gray"">
                                              <BorderSkin SkinStyle=""Emboss"" />
                                              <ChartAreas>
                                              <ChartArea Name=""Default"" _Template_=""All"" BackColor=""Wheat""
                                                         BackSecondaryColor=""White"" BorderColor=""64,64,64,64""
                                                         BorderDashStyle=""Solid"" ShadowColor=""Transparent"">
                                              </ChartArea>
                                              </ChartAreas>
                                              </Chart>");

            chart.AddSeries(
                chartType:"Column",
                yValues:productList.Select(e => e.Price).ToArray(),
                xValue:productList.Select(e => e.Name).ToArray()
                );
            ViewBag.Chart = chart.Write();
            return View();
        }

    }
}
