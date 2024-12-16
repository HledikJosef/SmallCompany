using SmallCompany.Models.Api.ApiResponseModel;

namespace SmallCompany.ServiceLayer
{
    public interface IApiSubjectService
    {
        public Task<EkonomickySubjekt> GetOneSubjectAsync(string ico);
    }
}
