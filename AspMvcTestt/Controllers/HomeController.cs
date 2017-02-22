using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcTestt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SecureMethod()
        {
            return View();
        }

        public ActionResult NonSecureMethod()
        {
            return View();
        }

        //test authen 
        //https://www.youtube.com/watch?v=ColwQX-dRJY&index=2&list=PLX-NQEtcSRcOSEMHTH2lY1XfDaDQmwJk3

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
//https://www.youtube.com/watch?v=Lp7nSImO5vk