using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemModelService
    {
        public void CreateItemModel(ItemBlazorModel itemBlazorModel);

        public List<ItemBlazorModel> GetBlazorItemModels();
    }
}
