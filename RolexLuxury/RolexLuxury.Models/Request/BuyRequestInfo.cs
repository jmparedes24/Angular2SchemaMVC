
using RolexLuxury.Models.BaseModel;
using RolexLuxury.Models.Catalog;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Request
{
    [Table("BuyRequestInfo")]
    public class BuyRequestInfo : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int BuyRequestInfoId { get; set; }

        [Column("BuyRequestId")]
        public int BuyRequestId { get; set; }

        [ForeignKey("BuyRequestId")]
        public virtual BuyRequest BuyRequest { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("AddressLine1")]
        public string AddressLine1 { get; set; }

        [Column("AddressLine2")]
        public string AddressLine2 { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("StateId")]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        [Column("Zip")]
        public string Zip { get; set; } 

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("TypeInformation")]
        public int TypeInformation { get; set; }
    }
}
