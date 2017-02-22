using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcTestt.Controllers
{
    public class GetSecureController : Controller
    {
        // GET: GetSecure
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetSecureDataHas(string username,string password)
        {

            string secureInfo = "";
            if((username == "admin") && (password == "admin"))
            {
                secureInfo = "Hey login pass";
            }
            else
            {
                secureInfo = "Wrong Pass na ja ";
            }
            return secureInfo;
        }

        public ActionResult ajaxcallapi()
        {
            return View();
        }
    }
}