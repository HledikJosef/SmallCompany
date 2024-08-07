namespace SmallCompany.ServiceLayer.ModelsBlazor
{
    public class ServiceProperty
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public int ServiceDateTypeId { get; set; } //např. text(string), číslo(float)..
        public ServiceDateType ServiceDateType { get; set; } = new ServiceDateType();
        public List<ServiceItemPropertyValue> ServiceItemPropertyValues { get; } = new List<ServiceItemPropertyValue>();
    }
}
