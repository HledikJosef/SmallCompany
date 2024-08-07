using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IUnitService
    {
        public List<ServiceUnit> GetUnitsFromDao();
    }
}
