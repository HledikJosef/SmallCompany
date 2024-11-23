using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface IPropertyService
    {
        public Task<List<Property>> GetPropertiesFromDaoAsync();
        public Task AddPropertyAsync(Property property);
    }
}
