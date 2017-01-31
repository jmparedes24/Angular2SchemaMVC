using RolexLuxury.Models.BaseModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Watch
{
    [Table("Watch")]
    public class Watch : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int WatchId { get; set; }

        [Column("WatchModelId")]
        public int WatchModelId { get; set; }

        [ForeignKey("WatchModelId")]
        public virtual WatchModel WatchModel { get; set; }

        [Column("ShortDescription")]
        public string ShortDesc { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("SalePrice")]
        public decimal SalePrice { get; set; }

        [Column("ItemNumber")]
        public int ItemNumber { get; set; }

        [Column("Manufacturer")]
        public string Manufacturer { get; set; }

        [Column("ModelNameNumber")]
        public string ModelNameNumber { get; set; }

        [Column("SerialYear")]
        public string SerialYear { get; set; }
        
        [Column("Grade")]
        public string Grade { get; set; }

        [Column("Gender")]
        public int Gender { get; set; }

        [Column("Features")]
        public string Features { get; set; }

        [Column("Case")]
        public string Case { get; set; }

        [Column("Dial")]
        public string Dial { get; set; }

        [Column("Bracelet")]
        public string Bracelet { get; set; }

        [Column("BoxPapers")]
        public string BoxPapers { get; set; }
    }
}
