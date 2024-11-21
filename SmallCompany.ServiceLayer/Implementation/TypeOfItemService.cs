using SmallCompany.DataLayer;
using SmallCompany.Models;
using SmallCompany.ServiceLayer.Mappers;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class TypeOfItemService : ITypeOfItemService
    {
        private readonly ITypeOfItemDao typeOfItemDao;

        public TypeOfItemService(ITypeOfItemDao typeOfItemDao)
        {
            this.typeOfItemDao = typeOfItemDao;
        }

        public async Task<List<ServiceTypeOfItem>> GetTypesOfItemsFromDaoAsync()
        {
            List<TypeOfItem> typesOfItemsFromDb = new List<TypeOfItem>();
            typesOfItemsFromDb = await typeOfItemDao.GetTypeOfItemsFromDbAsync();

            List<ServiceTypeOfItem> serviceTypesOfItemsFromDb = new List<ServiceTypeOfItem>();
            serviceTypesOfItemsFromDb = typesOfItemsFromDb.Select(type => ServiceTypeOfItemMapper.MapServiceTypeOfItemFromDao(type)).ToList();

            return serviceTypesOfItemsFromDb;
        }

        public Task AddTypeOfItemAsync(ServiceTypeOfItem serviceTypeOfItem)
        {
            TypeOfItem typeOfItem = new TypeOfItem();
            typeOfItem = ServiceTypeOfItemMapper.MapServiceTypeOfItemToDao(serviceTypeOfItem);

            return typeOfItemDao.AddTypeOfItemToDbAsync(typeOfItem);
        }
    }
}
