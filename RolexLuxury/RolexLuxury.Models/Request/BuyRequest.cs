using System;
using RolexLuxury.Models.BaseModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Request
{
    public class BuyRequest : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int BuyRequestId { get; set; }

        [Column("DateRequested")]
        public DateTime DateRequested { get; set; }
    }
}
