using RolexLuxury.Common.BaseClases;
using RolexLuxury.Models.Watch;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolexLuxury.Data.Sql.Repository
{
    public class WatchModelRepository : BaseRepository<WatchModel>
    {
        public WatchModelRepository(RolexLuxuryDBContext context) : base(context)
        {
        }        
    }
}
