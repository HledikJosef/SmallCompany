using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IPropertiesService
    {
        public List<PropertiesBlazorModel> GetBlazorProperties();
        public List<UnitBlazorModel> GetBlazorUnits();
        public List<ItemTypeBlazorModel> GetBlazorItemTypes();
    }
}
