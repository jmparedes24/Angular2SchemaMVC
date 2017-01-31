using RolexLuxury.Common;
using RolexLuxury.Common.Helper;
using RolexLuxury.Models.Catalog;
using RolexLuxury.Models.Request;
using RolexLuxury.Models.Watch;
using System.Data.Entity;

namespace RolexLuxury.Data.Sql
{
    public class RolexLuxuryDBContext : DbContext
    {
        public RolexLuxuryDBContext() : base(DBUtils.GetConnectionString(Constants.DbRolexLuxuryDBConnectionString)){ }

        public virtual DbSet<State> States { get; set; }

        public virtual DbSet<WatchModel> WatchModels { get; set; }

        public virtual DbSet<Watch> Watches { get; set; }

        public virtual DbSet<BuyRequest> BuyRequests { get; set; }

        public virtual DbSet<BuyRequestInfo> BuyRequestsInfo { get; set; }

        public virtual DbSet<QuoteRequest> QuoteRequests { get; set; }
    }
}
