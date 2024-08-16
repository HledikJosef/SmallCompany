using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
	public interface IPropertyService
	{
		public Task<List<ServiceProperty>> GetPropertiesFromDao();
		public Task AddProperty(ServiceProperty serviceProperty);
	}
}
