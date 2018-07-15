using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Helpers
{
    public static class Utils
    {
        public static string GetRouteValue2(this WebViewPage view, string name)
        {
            return view.ViewContext.RouteData.Values[name]?.ToString();
        }
        public static string GetModelStateValue2(this WebViewPage view, string name)
        {
            return view.ViewContext.ViewData.ModelState[name]?.Value.AttemptedValue;
        }
    }
}