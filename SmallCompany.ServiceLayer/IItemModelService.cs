using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemModelService
    {
        public void CreateItemModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties, string unit);
        public List<ItemBlazorModel> GetBlazorItemModels();
    }
}
