using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IPropertyDao
    {
        public List<Property> GetPropertiesFromSql();
        public void AddPropertyToSql(Property property);
    }
}
