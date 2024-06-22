namespace SmallCompany.DataLayer.Models
{
    public class PropertyModel
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; } = String.Empty;
        public string PropertyType { get; set; } = String.Empty;
        public string PropertyDescription { get; set; } = String.Empty;

    }
}
