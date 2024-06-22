namespace SmallCompany.DataLayer.Models
{
    public class ItemOnStock
    {
        public int ItemId { get; set; }
        public string ItemGroupName { get; set; } = String.Empty;
        public string ItemDescription { get; set; } = String.Empty;
        public string ItemType { get; set; } = String.Empty;
        public string? ItemColor { get; set; }
        public float? ItemHardness { get; set; }
        public float? ItemDensity { get; set; }
        public float? ItemDiameter { get; set; }
        public float? ItemWidth { get; set; }
        public float? ItemLength { get; set; }
        public float? ItemHigh { get; set; }
        public float? ItemThickness { get; set; }
        public float? ItemWeight { get; set; }
        public float? ItemQuantity { get; set; }
        public string ItemUnit { get; set; } = String.Empty;
        public int StockId { get; set; }
    }
}
