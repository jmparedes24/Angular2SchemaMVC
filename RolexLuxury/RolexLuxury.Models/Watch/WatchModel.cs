using RolexLuxury.Models.BaseModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Watch
{
    [Table("WatchModel")]
    public class WatchModel : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int WatchModelId { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Category")]
        public string Category { get; set; }
    }
}
