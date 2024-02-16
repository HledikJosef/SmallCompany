namespace SmallCompany.DataLayer.Models
{
    public class MaterialModel
    {
        public int? MaterialId { get; set; }
        public string MaterialGroupName { get; set; }
        public string MaterialDescription { get; set; }
        public bool MaterialColor { get; set; }
        public bool MaterialHardness { get; set; }
        public bool MaterialDensity { get; set; }
        public bool MaterialDiameter { get; set; }
        public bool MaterialWidth { get; set; }
        public bool MaterialLength { get; set; }
        public bool MaterialHigh { get; set; }
        public bool MaterialThickness { get; set; }
        public bool MaterialWeight { get; set; }
        public bool IsValid { get; set; }

    }
}
