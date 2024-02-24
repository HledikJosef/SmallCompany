using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Impl
{
    public class ItemModelCreator : IItemModelCreator
    {
        private readonly IItemModelDao itemModelDao;

        public ItemModelCreator(IItemModelDao itemModelDao)
        {
            this.itemModelDao = itemModelDao;
        }


        public bool CreateItemModel(string itemGroupName, string itemDescription, List<PropertiesBlazorModel> blazorProperties, string unit)
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
            bool isSuccsesfull = itemModelDao.WriteItemModel(itemModel);
            return isSuccsesfull;


        }


    }
}
