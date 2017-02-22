using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcAuthv0.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        #region Index method
        /// <summary>    
        /// Index method.    
        /// </summary>    
        /// <returns>Returns - Index view</returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return this.View();
        }
        #endregion
        #region Admin Only Link

        /// <summary>
        /// Admin only link method
        /// </summary>
        /// <returns>Returns - Admin only link view</returns>
        [Authorize(Roles = "1")]
        public ActionResult AdminOnlylink()
        {

            return this.View();
        }
        #endregion
    }
}