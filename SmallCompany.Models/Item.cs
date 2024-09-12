namespace SmallCompany.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public int UnitId { get; set; }
		public int TypeOfItemId { get; set; }
		public Unit Unit { get; set; } = null!;
		public TypeOfItem TypeOfItem { get; set; } = null!;
		public List<ItemPropertyValue> ItemPropertyValues { get; set; } = new List<ItemPropertyValue>();

	}
}
