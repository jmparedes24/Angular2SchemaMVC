using RolexLuxury.Common.Interface;
using RolexLuxury.Models.Watch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RolexLuxury.Areas.Watch.Controllers
{
    public class WatchModelController : Controller
    {
        private IRepository<WatchModel> _repositoryModels;
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WatchModelController(IRepository<WatchModel> repositoryModels)
        {
            _repositoryModels = repositoryModels;
        }

        // GET: Watch/WatchModel
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetWatches()
        {
            try
            {
                var result = await _repositoryModels.Get();

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                _log.Error(string.Format("Error:{0}", ex.Message), ex);
                throw;
            }
        }
    }
}