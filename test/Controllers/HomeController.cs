using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("Invoking index method of home controller");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Testingg  Helooo Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}