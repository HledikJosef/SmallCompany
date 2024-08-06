namespace SmallCompany.Models
{
    public class Unit //číselník jednotek pro ukládání položek na sklad
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Item> Items { get; } = new List<Item>();

    }
}
