using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class PropertyDao : IPropertyDao
    {
        private readonly ApplicationDbContext context;

        public PropertyDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Property> GetPropertiesFromSql()
        {
            List<Property> propertiesFromSql = new List<Property>();
            propertiesFromSql = context.Properties.ToList();

            return propertiesFromSql;
        }

        public void AddPropertyToSql(Property property)
        {
            context.Properties.Add(property);
        }
    }
}
