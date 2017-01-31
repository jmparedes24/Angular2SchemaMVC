using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RolexLuxury.Controllers
{
    public class HomeController : Controller
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // GET: Home
        public ActionResult Index()
        {            
            return View();
        }


    }
}