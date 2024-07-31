using SmallCompany.DataLayer;
using SmallCompany.Models;
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

        public void CreateItemStockRecord(ItemStockRecordBlazorModel item)
        {
            ItemOnStock itemStockRecordModel = MapItemStockRecord(item);
            itemStockDao.WriteItemOnStock(itemStockRecordModel);
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

        public List<ItemStockRecordBlazorModel> CreateItemsOnStockOutput(string itemModel)
        {
            List<ItemStockRecordBlazorModel> blazorItemsOnStock = new List<ItemStockRecordBlazorModel>();
            List<ItemOnStock> itemsOnStockFromSql = itemStockDao.ReadItemsOnStock(itemModel);
            blazorItemsOnStock = itemsOnStockFromSql.Select(item => MapItemStockOuput(item)).ToList();
            return blazorItemsOnStock;
        }

        private ItemStockRecordBlazorModel MapItemStockOuput(ItemOnStock itemsOnStockFromSql)
        {
            ItemStockRecordBlazorModel itemStockRecordBlazorModel = new ItemStockRecordBlazorModel();
            itemStockRecordBlazorModel.ItemId = itemsOnStockFromSql.ItemId;
            itemStockRecordBlazorModel.ItemGroupName = itemsOnStockFromSql.ItemGroupName;
            itemStockRecordBlazorModel.ItemDescription = itemsOnStockFromSql.ItemDescription;
            itemStockRecordBlazorModel.ItemType = itemsOnStockFromSql.ItemType;
            itemStockRecordBlazorModel.ItemColor = itemsOnStockFromSql.ItemColor;
            itemStockRecordBlazorModel.ItemHardness = itemsOnStockFromSql.ItemHardness;
            itemStockRecordBlazorModel.ItemDensity = itemsOnStockFromSql.ItemDensity;
            itemStockRecordBlazorModel.ItemDiameter = itemsOnStockFromSql.ItemDiameter;
            itemStockRecordBlazorModel.ItemWidth = itemsOnStockFromSql.ItemWidth;
            itemStockRecordBlazorModel.ItemLength = itemsOnStockFromSql.ItemLength;
            itemStockRecordBlazorModel.ItemHigh = itemsOnStockFromSql.ItemHigh;
            itemStockRecordBlazorModel.ItemThickness = itemsOnStockFromSql.ItemThickness;
            itemStockRecordBlazorModel.ItemWeight = itemsOnStockFromSql.ItemWeight;
            itemStockRecordBlazorModel.ItemQuantity = itemsOnStockFromSql.ItemQuantity;
            itemStockRecordBlazorModel.ItemUnit = itemsOnStockFromSql.ItemUnit;
            itemStockRecordBlazorModel.StockId = itemsOnStockFromSql.StockId;

            return itemStockRecordBlazorModel;

        }
    }
}
