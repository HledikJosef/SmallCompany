namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ico { get; set; } = string.Empty;
        public string Dic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsSupplier { get; set; }
        public bool IsPurchaser { get; set; }
        public Address Address { get; set; } = new Address();
        public Address DeliveryAddress { get; set; } = new Address();
        public ContactPerson ContactPerson { get; set; } = new ContactPerson();
        public Currency Currency { get; set; } = new Currency();
        public int PaymentCondition { get; set; }
        public PriceGroup PriceGroup { get; set; } = new PriceGroup();

    }
}
