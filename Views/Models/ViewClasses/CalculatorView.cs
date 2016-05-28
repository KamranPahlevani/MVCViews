using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Models.ViewClasses
{
    public abstract class CalculatorView:WebViewPage
    {
        [Inject]
        public ICalculator Calculator { get; set; }
    }
}