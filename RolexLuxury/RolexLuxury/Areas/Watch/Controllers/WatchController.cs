using RolexLuxury.Common.Interface;
using RolexLuxury.Models.Watch;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RolexLuxury.Areas.Watch.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch/Watch
        public ActionResult Index()
        {
            return View();
        }       
    }
}