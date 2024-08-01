using System.ComponentModel.DataAnnotations;

namespace SmallCompany.Models
{

    public class UnitModel
    {
        [Key]
        public int UnitId { get; set; }
        public string ItemUnit { get; set; } = String.Empty;
    }
}
