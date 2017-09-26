using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SodingAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "TaskManagers");// added by Waqar Hassan on 20170926, "to route all paths to Task"
            //return View();// commented by Waqar Hassan on 20170926 
        }

        public ActionResult About()
        {
            return RedirectToAction("Index", "TaskManagers");// added by Waqar Hassan on 20170926, "to route all paths to Task"
            //ViewBag.Message = "Your application description page.";// commented by Waqar Hassan on 20170926

            //return View();// commented by Waqar Hassan on 20170926 
        }

        public ActionResult Contact()
        {
            return RedirectToAction("Index", "TaskManagers");// added by Waqar Hassan on 20170926, "to route all paths to Task"
            //ViewBag.Message = "Your contact page.";// commented by Waqar Hassan on 20170926 

            //return View();// commented by Waqar Hassan on 20170926 
        }
    }
}