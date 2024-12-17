namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorPartner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ico { get; set; } = string.Empty;
        public string Dic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsSupplier { get; set; }
        public bool IsPurchaser { get; set; }
        public BlazorAddress Address { get; set; } = new BlazorAddress();
        public BlazorDeliveryAddress DeliveryAddress { get; set; } = new BlazorDeliveryAddress();
        public BlazorContactPerson ContactPerson { get; set; } = new BlazorContactPerson();
        public BlazorCurrency Currency { get; set; } = new BlazorCurrency();
        public int PaymentCondition { get; set; }
        public BlazorPriceGroup PriceGroup { get; set; } = new BlazorPriceGroup();

    }
}
