namespace SmallCompany.Models
{
    public class ItemPropertyValue
    {
        public int ItemId { get; set; }
        public int PropertyId { get; set; }
        public Item Item { get; set; } = null!;
        public Property Property { get; set; } = null!;
        public string Value { get; set; } = String.Empty; //value může být text barvba nebo číslo. V tabulce bude vše uloženo jako text.
    }
}
