namespace SmallCompany.ServiceLayer.ModelsBlazor
{
    public class ServiceItemPropertyValue
    {
        public int Id { get; set; }
        public string Value { get; set; } = String.Empty; //value může být text barva nebo číslo. V tabulce bude vše uloženo jako text.

        public int ServiceItemId { get; set; }
        public int ServicePropertyId { get; set; }

        public ServiceItem SereviceItem { get; set; } = new();
        public ServiceProperty ServiceProperty { get; set; } = new();
    }
}
