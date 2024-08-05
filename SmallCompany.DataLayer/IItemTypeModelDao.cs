using SmallCompany.Models;

namespace SmallCompany.DataLayer
{
    public interface IItemTypeModelDao
    {
        public List<ItemType> ReadItemTypes();
        public List<ItemType> ReadItemTypesEF();

    }
}
