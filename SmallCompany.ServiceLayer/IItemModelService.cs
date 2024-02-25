using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemModelService
    {
        public bool CreateItemModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties, string unit);
        public List<ItemBlazorModel> GetBlazorItemModels();
    }
}
