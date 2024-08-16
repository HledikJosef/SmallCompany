using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
    public static class ServiceDateTypeMapper
    {
        public static ServiceDateType MapServiceDateTypFromDao(DateType dateType)
        {
            ServiceDateType serviceDateType = new();
            serviceDateType.Id = dateType.Id;
            serviceDateType.Name = dateType.Name;

            return serviceDateType;
        }

        public static DateType MapServiceDateTypToDao(ServiceDateType serviceDateType)
        {
            DateType dateType = new();
            dateType.Id = serviceDateType.Id;
            dateType.Name = serviceDateType.Name;

            return dateType;
        }
    }


}
