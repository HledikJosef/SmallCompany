using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;



namespace SmallCompany.ServiceLayer.Impl
{
    public class ItemModelService : IItemModelService
    {
        private readonly IItemModelDao itemModelDao;

        public ItemModelService(IItemModelDao itemModelDao)
        {
            this.itemModelDao = itemModelDao;
        }


        public void CreateItemModel(ItemBlazorModel itemBlazorModel)
        {
            ItemModel itemModel = new();
            itemModel = MapItemBlazorModel(itemBlazorModel);
            itemModelDao.WriteItemModelEF(itemModel);
        }

        private ItemModel MapItemBlazorModel(ItemBlazorModel itemBlazorModel)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.ItemId = itemBlazorModel.ItemId;
            itemModel.ItemGroupName = itemBlazorModel.ItemGroupName;
            itemModel.ItemDescription = itemBlazorModel.ItemDescription;
            itemModel.ItemColor = itemBlazorModel.ItemColor;
            itemModel.ItemHardness = itemBlazorModel.ItemHardness;
            itemModel.ItemDensity = itemBlazorModel.ItemDensity;
            itemModel.ItemDiameter = itemBlazorModel.ItemDiameter;
            itemModel.ItemRadius = itemBlazorModel.ItemRadius;
            itemModel.ItemWidth = itemBlazorModel.ItemWidth;
            itemModel.ItemLength = itemBlazorModel.ItemLength;
            itemModel.ItemHigh = itemBlazorModel.ItemHigh;
            itemModel.ItemThickness = itemBlazorModel.ItemThickness;
            itemModel.ItemWeight = itemBlazorModel.ItemWeight;
            itemModel.ItemUnit = itemBlazorModel.ItemUnit;

            return itemModel;

        }

        public List<ItemBlazorModel> GetBlazorItemModels()
        {
            List<ItemModel> itemModels = itemModelDao.ReadItemModelsEF();
            List<ItemBlazorModel> blazorItemModels = itemModels.Select(itemModel => MapItemModel(itemModel)).ToList();


            return blazorItemModels;
        }

        private ItemBlazorModel MapItemModel(ItemModel itemModel)
        {
            ItemBlazorModel blazorItemModel = new ItemBlazorModel();
            blazorItemModel.ItemId = itemModel.ItemId;
            blazorItemModel.ItemGroupName = itemModel.ItemGroupName;
            blazorItemModel.ItemDescription = itemModel.ItemDescription;
            blazorItemModel.ItemColor = itemModel.ItemColor;
            blazorItemModel.ItemHardness = itemModel.ItemHardness;
            blazorItemModel.ItemDensity = itemModel.ItemDensity;
            blazorItemModel.ItemDiameter = itemModel.ItemDiameter;
            blazorItemModel.ItemRadius = itemModel.ItemRadius;
            blazorItemModel.ItemWidth = itemModel.ItemWidth;
            blazorItemModel.ItemLength = itemModel.ItemLength;
            blazorItemModel.ItemHigh = itemModel.ItemHigh;
            blazorItemModel.ItemThickness = itemModel.ItemThickness;
            blazorItemModel.ItemWeight = itemModel.ItemWeight;
            blazorItemModel.ItemUnit = itemModel.ItemUnit;
            blazorItemModel.IsValid = itemModel.IsValid;

            return blazorItemModel;

        }


    }
}
