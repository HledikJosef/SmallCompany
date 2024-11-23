using SmallCompany.DataLayer;
using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class TypeOfItemService : ITypeOfItemService
    {
        private readonly ITypeOfItemDao typeOfItemDao;

        public TypeOfItemService(ITypeOfItemDao typeOfItemDao)
        {
            this.typeOfItemDao = typeOfItemDao;
        }

        public async Task<List<TypeOfItem>> GetTypesOfItemsFromDaoAsync()
        {
            List<TypeOfItem> typesOfItemsFromDb = new List<TypeOfItem>();
            typesOfItemsFromDb = await typeOfItemDao.GetTypeOfItemsFromDbAsync();

            return typesOfItemsFromDb;
        }

        public Task AddTypeOfItemAsync(TypeOfItem typeOfItem)
        {
            return typeOfItemDao.AddTypeOfItemToDbAsync(typeOfItem);
        }
    }
}
