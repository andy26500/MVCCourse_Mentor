using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        [產生ViewBag下有一個Message可以用]
        public ActionResult Index()
        {
            return View();
        }

        [產生ViewBag下有一個Message可以用]
        public ActionResult About()
        {
            //throw new ArgumentException("ERROR");

            return View();
        }

        [LocalOnly]
        [產生ViewBag下有一個Message可以用]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}