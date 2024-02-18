namespace SmallCompany.DataLayer.Models
{
    public class ItemModel
    {
        public string ItemGroupName { get; set; }
        public string ItemDescription { get; set; }
        public bool ItemColor { get; set; }
        public bool ItemHardness { get; set; }
        public bool ItemDensity { get; set; }
        public bool ItemDiameter { get; set; }
        public bool ItemWidth { get; set; }
        public bool ItemLength { get; set; }
        public bool ItemHigh { get; set; }
        public bool ItemThickness { get; set; }
        public bool ItemWeight { get; set; }
        public string Unit { get; set; }
        public bool IsValid { get; set; }


    }
}
