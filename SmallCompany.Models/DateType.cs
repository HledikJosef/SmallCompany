namespace SmallCompany.Models
{
    public class DateType
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Property> Properties { get; } = new List<Property>();
    }
}
