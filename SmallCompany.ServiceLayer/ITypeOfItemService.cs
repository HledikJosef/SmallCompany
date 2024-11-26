using SmallCompany.Models;

namespace SmallCompany.ServiceLayer
{
    public interface ITypeOfItemService
    {
        public Task<List<TypeOfItem>> GetTypesOfItemsFromDaoAsync();
        public Task AddTypeOfItemAsync(TypeOfItem typeOfItem);
        public Task UpdateTypeOfItemAsync(TypeOfItem typeOfItem);

    }
}
