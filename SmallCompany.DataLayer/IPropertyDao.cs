using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IPropertyDao
    {
        public Task<List<Property>> GetPropertiesFromDbAsync();
        public Task AddPropertyToDbAsync(Property property);
        public Task UpdatePropertyInDbAsync(Property property);

    }
}
