using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemTypModelDao
    {
        public List<ItemType> ReadItemTypes();
    }
}
