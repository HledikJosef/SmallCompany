using SmallCompany.Models.Api.ApiRequestModel;
using SmallCompany.Models.Api.ApiResponseModel;

namespace SmallCompany.DataLayer.Api
{
    public interface IEkonomickeSubjektyDao
    {
        public Task<EkonomickySubjekt> GetOneSubjectAsync(string ico);
        public Task<EkonomickeSubjektySeznam> GetListOfSubjects(EkonomickeSubjektyKomplexFiltr komplexFiltr);
    }
}
