using System.ComponentModel.DataAnnotations;

namespace SmallCompany.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeId { get; set; }
        public string Itemtype { get; set; } = String.Empty;
    }
}
