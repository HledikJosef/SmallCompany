using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemModelDao
    {
        public List<ItemModel> ReadItemModels();
        public List<ItemModel> ReadItemModelsEF();
        public void WriteItemModel(ItemModel itemModel);
        public void WriteItemModelEF(ItemModel itemModel);

    }
}
