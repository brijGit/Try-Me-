using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is about Try Application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Try App";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Try Contact Page..";

            return View();
        }
    }
}
