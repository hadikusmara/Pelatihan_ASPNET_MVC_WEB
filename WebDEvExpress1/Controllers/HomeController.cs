using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDEvExpress1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult index2()
        {
            ViewBag.Message = "Sempel Devexpress.";

            return View();
        }
        public ActionResult Overview()
        {
            ViewBag.Message = "Sempel Overview.";

            return View();
        }
        
    }
}