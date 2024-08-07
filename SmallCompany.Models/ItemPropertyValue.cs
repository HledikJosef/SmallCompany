namespace SmallCompany.Models
{
    public class ItemPropertyValue
    {
        public int Id { get; set; }
        public string Value { get; set; } = String.Empty; //value může být text barva nebo číslo. V tabulce bude vše uloženo jako text.

        public int ItemId { get; set; }
        public int PropertyId { get; set; }

        public Item Item { get; set; } = null!;
        public Property Property { get; set; } = null!;

    }
}
