using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IUnitService
    {
        public Task<List<ServiceUnit>> GetUnitsFromDao();
        public Task AddUnit(ServiceUnit serviceUnit);
    }
}
