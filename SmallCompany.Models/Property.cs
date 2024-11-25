namespace SmallCompany.Models
{
    public class Property //např. výška, délka, hmotnost
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public int DateTypeId { get; set; } //např. text(string), číslo(float)..
        public bool IsActive { get; set; }

        public DateType DateType { get; set; } = null!;

        public List<ItemPropertyValue> ItemPropertyValues { get; set; } = new List<ItemPropertyValue>();

    }
}
