using SmallCompany.Models;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Mappers
{
    public static class ServiceTypeOfItemMapper
    {
        public static ServiceTypeOfItem MapServiceTypeOfItemFromDao(TypeOfItem typeOfItem)
        {
            ServiceTypeOfItem serviceTypeOfItem = new ServiceTypeOfItem();
            serviceTypeOfItem.Id = typeOfItem.Id;
            serviceTypeOfItem.Name = typeOfItem.Name;

            return serviceTypeOfItem;

        }

        public static TypeOfItem MapServiceTypeOfItemToDao(ServiceTypeOfItem serviceTypeOfItem)
        {
            TypeOfItem typeOfItem = new TypeOfItem();
            typeOfItem.Id = serviceTypeOfItem.Id;
            typeOfItem.Name = serviceTypeOfItem.Name;

            return typeOfItem;
        }
    }
}
