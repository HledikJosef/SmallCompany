using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
	public interface IPropertyService
	{
		public Task<List<ServiceProperty>> GetPropertiesFromDaoAsync();
		public Task AddPropertyAsync(ServiceProperty serviceProperty);
	}
}
