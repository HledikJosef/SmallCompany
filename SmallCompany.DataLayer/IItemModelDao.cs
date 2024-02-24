using SmallCompany.DataLayer.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemModelDao
    {
        public List<ItemModel> ReadItemModels();
        public bool WriteItemModel(ItemModel itemModel);
    }
}
