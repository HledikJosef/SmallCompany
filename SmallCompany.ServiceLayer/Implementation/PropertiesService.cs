using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Impl
{
    public class PropertiesService : IPropertiesService
    {
        private readonly IPropertyModelDao propertyModelDao;
        private readonly IUnitModelDao unitModelDao;
        private readonly IItemTypModelDao itemTypModelDao;

        public PropertiesService(IPropertyModelDao propertyModelDao, IUnitModelDao unitModelDao, IItemTypModelDao itemTypModelDao)
        {
            this.propertyModelDao = propertyModelDao;
            this.unitModelDao = unitModelDao;
            this.itemTypModelDao = itemTypModelDao;
        }

        public List<PropertiesBlazorModel> GetBlazorProperties()
        {
            List<PropertyModel> propertiesFromSql = propertyModelDao.ReadProperties();
            List<PropertiesBlazorModel> blazorProperties = propertiesFromSql.Select(property => MapProperties(property)).ToList();

            return blazorProperties;
        }

        private PropertiesBlazorModel MapProperties(PropertyModel properties)
        {
            PropertiesBlazorModel propertiesBlazorModel = new PropertiesBlazorModel();
            propertiesBlazorModel.PropertyId = properties.PropertyId;
            propertiesBlazorModel.PropertyName = properties.PropertyName;
            propertiesBlazorModel.PropertyType = properties.PropertyType;
            propertiesBlazorModel.PropertyDescription = properties.PropertyDescription;

            return propertiesBlazorModel;
        }

        public List<UnitBlazorModel> GetBlazorUnits()
        {
            List<UnitModel> unitsFromSql = unitModelDao.ReadUnits();
            List<UnitBlazorModel> blazorUnits = unitsFromSql.Select(unit => MapUnits(unit)).ToList();
            return blazorUnits;
        }

        private UnitBlazorModel MapUnits(UnitModel units)
        {
            UnitBlazorModel blazorUnit = new UnitBlazorModel();
            blazorUnit.UnitId = units.UnitId;
            blazorUnit.Unit = units.ItemUnit;

            return blazorUnit;
        }

        public List<ItemTypeBlazorModel> GetBlazorItemTypes()
        {
            List<ItemType> itemTypesFromSql = itemTypModelDao.ReadItemTypes();
            List<ItemTypeBlazorModel> blazorItemTypes = itemTypesFromSql.Select(item => MapItemTyps(item)).ToList();

            return blazorItemTypes;
        }

        private ItemTypeBlazorModel MapItemTyps(ItemType itemTyp)
        {
            ItemTypeBlazorModel blazorItemTyp = new ItemTypeBlazorModel();
            blazorItemTyp.ItemTypeId = itemTyp.ItemTypeId;
            blazorItemTyp.ItemType = itemTyp.Itemtype;

            return blazorItemTyp;
        }


    }
}
