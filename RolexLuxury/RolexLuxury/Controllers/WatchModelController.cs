using RolexLuxury.Common.Interface;
using RolexLuxury.Models.Watch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RolexLuxury.Controllers
{
    public class WatchModelController : ApiController
    {
        private IRepository<WatchModel> _repositoryModels;
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public WatchModelController(IRepository<WatchModel> repositoryModels)
        {
            _repositoryModels = repositoryModels;
        }

        public async Task<List<WatchModel>> Get()
        {
            try
            {
                var result = await _repositoryModels.Get();

                return result.ToList();
            }
            catch (Exception ex)
            {
                _log.Error(string.Format("Error:{0}", ex.Message), ex);
                throw;
            }
        }
    }
}
