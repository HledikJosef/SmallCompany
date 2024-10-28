namespace SmallCompany.ServiceLayer.ModelsService
{
	public class ServiceItem
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public int UnitId { get; set; }
		public int TypeOfItemId { get; set; }
		public ServiceUnit ServiceUnit { get; set; } = null!;
		public ServiceTypeOfItem ServiceTypeOfItem { get; set; } = null!;
		public List<ServiceItemPropertyValue> ServiceItemPropertyValues { get; set; } = new List<ServiceItemPropertyValue>();
	}
}
