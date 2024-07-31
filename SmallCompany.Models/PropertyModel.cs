using System.ComponentModel.DataAnnotations;

namespace SmallCompany.Models
{
    public class PropertyModel
    {
        [Key]
        public int PropertyId { get; set; }
        public string PropertyName { get; set; } = String.Empty;
        public string PropertyType { get; set; } = String.Empty;
        public string PropertyDescription { get; set; } = String.Empty;

    }
}
