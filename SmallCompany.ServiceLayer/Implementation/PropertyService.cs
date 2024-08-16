using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
	public class PropertyService : IPropertyService
	{
		private readonly IPropertyDao propertyDao;

		public PropertyService(IPropertyDao propertyDao)
		{
			this.propertyDao = propertyDao;
		}

		public async Task<List<ServiceProperty>> GetPropertiesFromDao()
		{
			List<Property> propertiesFromDao = new List<Property>();
			propertiesFromDao = await propertyDao.GetPropertiesFromDbAsync();

			List<ServiceProperty> servicePropertiesFromDao = new List<ServiceProperty>();
			servicePropertiesFromDao = propertiesFromDao.Select(prop => ServicePropertyMapper.MapServicePropertyFromDao(prop)).ToList();

			return servicePropertiesFromDao;

		}

		public Task AddProperty(ServiceProperty serviceProperty)
		{
			Property property = new Property();
			property = ServicePropertyMapper.MapServicePropertyToDao(serviceProperty);

			return propertyDao.AddPropertyToDb(property);
		}
	}
}
