using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IPropertyModelDao
    {
        public List<PropertyModel> ReadProperties();
        public List<PropertyModel> ReadPropertiesEF();
    }
}
