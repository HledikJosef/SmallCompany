using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IPropertyModelDao
    {
        public List<PropertyModel> ReadProperties();
    }
}
