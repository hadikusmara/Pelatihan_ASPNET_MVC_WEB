using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDEvExpress1.Controllers
{
    public class ProjectDEvController : Controller
    {
        public ActionResult Overview()
        {
            ViewBag.Message = "Sempel Overview.";

            return View();
        }
        public ActionResult Simple_Array()
        {
            ViewBag.Message = "Sempel Array.";

            return View();
        }
        public ActionResult Web_API_Service()
        {
            ViewBag.Message = "Web_API_Service.";

            return View();
        }
        public ActionResult Grid_Edit()
        {
            ViewBag.Message = "Grid_Edit";

            return View();
        }
    
    public ActionResult Column3RdPartyEngineTemplate()
    {
            
            ViewBag.Message = "Column3RdPartyEngineTemplate";

        return View();
    }
        public ActionResult CollaborativeEditing()
        {

            ViewBag.Message = "CollaborativeEditing";

            return View();
        }

        public ActionResult RowEditingAndEditingEvents()
        {

            ViewBag.Message = "RowEditingAndEditingEvents";

            return View();
        }
        

    }
}