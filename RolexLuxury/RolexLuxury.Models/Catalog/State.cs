
using RolexLuxury.Models.BaseModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolexLuxury.Models.Catalog
{
    public class State : BaseInfoModel
    {
        [Key]
        [Column("Id")]
        public int StateId { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
