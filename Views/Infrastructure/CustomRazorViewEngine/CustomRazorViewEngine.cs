﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Infrastructure.CustomRazorViewEngine
{
    public class CustomRazorViewEngine:RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            this.ViewLocationFormats = new string[]{
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Common/{0}.cshtml"
            };
        }
    }
}