using System.ComponentModel.DataAnnotations;

namespace SmallCompany.Models
{

    public class StockModel
    {
        [Key]
        public int StockId { get; set; }
        public string StockTitel { get; set; } = String.Empty;
        public string StockDescription { get; set; } = String.Empty;
        public string StockLocation { get; set; } = String.Empty;
        public bool IsValid { get; set; }

    }
}
