using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class ItemStockService : IItemStockService
    {
        private readonly IItemStockDao itemStockDao;

        public ItemStockService(IItemStockDao itemStockDao)
        {
            this.itemStockDao = itemStockDao;
        }

        public bool CreateItemStockRecord(ItemStockRecordBlazorModel item)
        {
            bool isSuccessful = false;
            ItemOnStock itemStockRecordModel = MapItemStockRecord(item);

            isSuccessful = itemStockDao.WriteItemOnStock(itemStockRecordModel);

            return isSuccessful;
        }

        private ItemOnStock MapItemStockRecord(ItemStockRecordBlazorModel item)
        {
            ItemOnStock itemStockRecordModel = new ItemOnStock();
            itemStockRecordModel.ItemId = item.ItemId;
            itemStockRecordModel.ItemGroupName = item.ItemGroupName;
            itemStockRecordModel.ItemDescription = item.ItemDescription;
            itemStockRecordModel.ItemType = item.ItemType;
            itemStockRecordModel.ItemColor = item.ItemColor;
            itemStockRecordModel.ItemHardness = item.ItemHardness;
            itemStockRecordModel.ItemDensity = item.ItemDensity;
            itemStockRecordModel.ItemDiameter = item.ItemDiameter;
            itemStockRecordModel.ItemWidth = item.ItemWidth;
            itemStockRecordModel.ItemLength = item.ItemLength;
            itemStockRecordModel.ItemHigh = item.ItemHigh;
            itemStockRecordModel.ItemThickness = item.ItemThickness;
            itemStockRecordModel.ItemWeight = item.ItemWeight;
            itemStockRecordModel.ItemQuantity = item.ItemQuantity;
            itemStockRecordModel.ItemUnit = item.ItemUnit;
            itemStockRecordModel.StockId = item.StockId;

            return itemStockRecordModel;
        }
    }
}
