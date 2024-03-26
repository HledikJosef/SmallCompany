using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
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


        public void CreateItemModel(string itemGroupName, string itemDescription, List<PropertiesBlazorModel> blazorProperties, string unit)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.ItemGroupName = itemGroupName;
            itemModel.ItemDescription = itemDescription;
            foreach (var property in blazorProperties)
            {
                switch (property.PropertyName)
                {
                    case "Barva":
                        itemModel.ItemColor = (bool)property.IsValid;
                        break;
                    case "Tvrdost":
                        itemModel.ItemHardness = (bool)property.IsValid;
                        break;
                    case "Hustota":
                        itemModel.ItemDensity = (bool)property.IsValid;
                        break;
                    case "Průměr":
                        itemModel.ItemDiameter = (bool)property.IsValid;
                        break;
                    case "Šířka":
                        itemModel.ItemWidth = (bool)property.IsValid;
                        break;
                    case "Délka":
                        itemModel.ItemLength = (bool)property.IsValid;
                        break;
                    case "Výška":
                        itemModel.ItemHigh = (bool)property.IsValid;
                        break;
                    case "Tloušťka":
                        itemModel.ItemThickness = (bool)property.IsValid;
                        break;
                    case "Hmotnost":
                        itemModel.ItemWeight = (bool)property.IsValid;
                        break;

                }

            }
            itemModel.ItemUnit = unit;
            itemModel.IsValid = true;
            itemModelDao.WriteItemModel(itemModel);

        }

        public List<ItemBlazorModel> GetBlazorItemModels()
        {
            List<ItemModel> itemModels = itemModelDao.ReadItemModels();
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
