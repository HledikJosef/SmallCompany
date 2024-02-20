using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Impl
{
    public class PropertiesService : IPropertiesService
    {
        private readonly IDBRecordReader dBRrecordReader;

        public PropertiesService(IConnectionStringProvider connectionStringProvider, IDBRecordReader dBRecordReader)
        {
            this.dBRrecordReader = dBRecordReader;
        }

        public List<PropertiesBlazorModel> GetBlazorProperties()
        {
            List<PropertyModel> propertiesFromSql = dBRrecordReader.ReadProperties();
            List<PropertiesBlazorModel> blazorProperties = propertiesFromSql.Select(property => MapProperties(property)).ToList();

            return blazorProperties;
        }

        private PropertiesBlazorModel MapProperties(PropertyModel properties)
        {
            PropertiesBlazorModel propertiesBlazorModel = new PropertiesBlazorModel();
            propertiesBlazorModel.Id = properties.Id;
            propertiesBlazorModel.PropertyName = properties.PropertyName;
            propertiesBlazorModel.PropertyType = properties.PropertyType;
            propertiesBlazorModel.PropertyDescription = properties.PropertyDescription;

            return propertiesBlazorModel;
        }

        public List<UnitBlazorModel> GetBlazorUnits()
        {
            List<UnitModel> unitsFromSql = dBRrecordReader.ReadUnits();
            List<UnitBlazorModel> blazorUnits = unitsFromSql.Select(unit => MapUnits(unit)).ToList();
            return blazorUnits;
        }

        private UnitBlazorModel MapUnits(UnitModel units)
        {
            UnitBlazorModel blazorUnit = new UnitBlazorModel();
            blazorUnit.Unit = units.ItemUnit;

            return blazorUnit;
        }

        public List<ItemTypBlazorModel> GetBlazorItemTyps()
        {
            List<ItemTyp> itemTypsFromSql = dBRrecordReader.ReadItemTyps();
            List<ItemTypBlazorModel> blazorItemTyps = itemTypsFromSql.Select(item => MapItemTyps(item)).ToList();

            return blazorItemTyps;
        }

        private ItemTypBlazorModel MapItemTyps(ItemTyp itemTyp)
        {
            ItemTypBlazorModel blazorItemTyp = new ItemTypBlazorModel();
            blazorItemTyp.ItemTyp = itemTyp.Itemtyp;

            return blazorItemTyp;
        }


    }
}
