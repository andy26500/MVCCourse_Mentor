using System;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class 產生ViewBag下有一個Message可以用Attribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Message = "Your application description page.";

            base.OnActionExecuting(filterContext);
        }
    }
}