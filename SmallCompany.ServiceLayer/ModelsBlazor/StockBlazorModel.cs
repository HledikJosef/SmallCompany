namespace SmallCompany.ServiceLayer.ModelsBlazor
{
    public class StockBlazorModel
    {
        public int StockId { get; set; }
        public string StockTitle { get; set; } = string.Empty;
        public string StockDescription { get; set; } = string.Empty;
        public string StockLocation { get; set; } = string.Empty;
        public bool IsValid { get; set; } = false;

        //public bool IsValid()
        //{
        //    if (string.IsNullOrWhiteSpace(StockTitle)) return false;
        //    if (string.IsNullOrWhiteSpace(StockDescription)) return false;
        //    if (string.IsNullOrWhiteSpace(StockLocation)) return false;
        //    return true;
        //}
    }
}
