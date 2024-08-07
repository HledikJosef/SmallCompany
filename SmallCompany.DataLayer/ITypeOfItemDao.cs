using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface ITypeOfItemDao
    {
        public List<TypeOfItem> GetTypeOfItemsFromSql();
        public void AddTypeOfItemToSql(TypeOfItem typeOfItem);
    }
}
