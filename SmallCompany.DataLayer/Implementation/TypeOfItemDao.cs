using SmallCompany.Models;
using SmallCompany.Models.Data;

namespace SmallCompany.DataLayer.Implementation
{
    public class TypeOfItemDao : ITypeOfItemDao
    {
        private readonly ApplicationDbContext context;

        public TypeOfItemDao(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<TypeOfItem> GetTypeOfItemsFromSql()
        {
            List<TypeOfItem> typeOfItemsFromSql = new List<TypeOfItem>();
            typeOfItemsFromSql = context.TypesOfItems.ToList();

            return typeOfItemsFromSql;
        }

        public void AddTypeOfItemToSql(TypeOfItem typeOfItem)
        {
            context.TypesOfItems.Add(typeOfItem);
        }
    }
}
