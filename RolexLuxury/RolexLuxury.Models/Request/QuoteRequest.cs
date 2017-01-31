
using RolexLuxury.Models.BaseModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Request
{
    public class QuoteRequest : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int QuoteRequestId { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Comments")]
        public string Comments { get; set; }
    }
}
