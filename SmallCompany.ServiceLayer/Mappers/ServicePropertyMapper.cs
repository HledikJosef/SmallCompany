using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
	public static class ServicePropertyMapper
	{
		public static ServiceProperty MapServicePropertyFromDao(Property property)
		{
			ServiceProperty serviceProperty = new ServiceProperty();
			serviceProperty.Id = property.Id;
			serviceProperty.Name = property.Name;
			serviceProperty.ServiceDateTypeId = property.DateTypeId;

			return serviceProperty;
		}

		public static Property MapServicePropertyToDao(ServiceProperty serviceProperty)
		{
			Property property = new Property();
			property.Id = serviceProperty.Id;
			property.Name = serviceProperty.Name;
			property.DateTypeId = serviceProperty.ServiceDateTypeId;

			return property;
		}
	}
}
