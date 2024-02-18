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

        public List<UnitModel> GetUnits()
        {
            List<UnitModel> units = new List<UnitModel>();
            return units;
        }


    }
}
