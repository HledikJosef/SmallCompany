using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface ITypeOfItemDao
    {
        public Task<List<TypeOfItem>> GetTypeOfItemsFromDbAsync();
        public Task AddTypeOfItemToDbAsync(TypeOfItem typeOfItem);
        public Task UpdateTypeOfItemInDbAsync(TypeOfItem typeOfItem);
    }
}
