namespace SmallCompany.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Ico { get; set; } = string.Empty;
        public string Dic { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public bool IsSupplier { get; set; }
        public bool IsPurchaser { get; set; }
        public Address Address { get; set; } = null!;
        public Address? DeliveryAddress { get; set; } = null!;
        public ContactPerson? ContactPerson { get; set; } = null!;
        public Currency Currency { get; set; } = null!;
        public int PaymentCondition { get; set; }
        public PriceGroup PriceGroup { get; set; } = null!;
    }
}
