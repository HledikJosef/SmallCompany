using SmallCompany.DataLayer;
using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyDao propertyDao;

        public PropertyService(IPropertyDao propertyDao)
        {
            this.propertyDao = propertyDao;
        }

        public async Task<List<Property>> GetPropertiesFromDaoAsync()
        {
            List<Property> propertiesFromDao = new List<Property>();
            propertiesFromDao = await propertyDao.GetPropertiesFromDbAsync();

            return propertiesFromDao;

        }

        public Task AddPropertyAsync(Property property)
        {
            return propertyDao.AddPropertyToDbAsync(property);
        }
    }
}
