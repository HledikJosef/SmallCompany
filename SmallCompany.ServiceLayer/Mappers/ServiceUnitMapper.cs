using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Mappers
{
    public static class ServiceUnitMapper
    {
        public static ServiceUnit MapServiceUnitsFromDao(Unit unit)
        {
            ServiceUnit serviceUnit = new ServiceUnit();

            serviceUnit.Id = unit.Id;
            serviceUnit.Name = unit.Name;

            return serviceUnit;
        }

        public static Unit MapServiceUnitsToDao(ServiceUnit serviceUnit)
        {
            Unit unit = new Unit();
            unit.Id = serviceUnit.Id;
            unit.Name = serviceUnit.Name;

            return unit;
        }
    }
}
