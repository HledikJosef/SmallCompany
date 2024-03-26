using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemModelDao
    {
        public List<ItemModel> ReadItemModels();
        public void WriteItemModel(ItemModel itemModel);
    }
}
