using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ServiceLayer
{
    public interface IUnitService
    {
        public Task<List<ServiceUnit>> GetUnitsFromDaoAsync();
        public Task AddUnitAsync(ServiceUnit serviceUnit);
    }
}
