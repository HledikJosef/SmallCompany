using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IUnitService
    {
        public List<ServiceUnit> GetUnitsFromDao();
        public Task AddUnit(ServiceUnit serviceUnit);
    }
}
