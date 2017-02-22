using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcTestt.Controllers
{
    [Authorize]
    public class AuthenController : Controller
    {
        // GET: Authen
        public ActionResult SecureMethod()
        {
            return View();
        }



    }
}