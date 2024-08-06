namespace SmallCompany.Models
{
    public class TypeOfItem //např.materiál, polotovar, výrobek..
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Item> Items { get; } = new List<Item>();
    }
}
