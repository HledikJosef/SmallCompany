using SmallCompany.DataLayer.Api;
using SmallCompany.Models.Api.ApiResponseModel;

namespace SmallCompany.ServiceLayer.Implementation
{
    public class ApiSubjectService : IApiSubjectService
    {
        private readonly IEkonomickeSubjektyDao ekonomickeSubjektyDao;

        public ApiSubjectService(IEkonomickeSubjektyDao ekonomickeSubjektyDao)
        {
            this.ekonomickeSubjektyDao = ekonomickeSubjektyDao;
        }


        public async Task<EkonomickySubjekt> GetOneSubjectAsync(string ico)
        {
            EkonomickySubjekt? subject = new EkonomickySubjekt();

            subject = await ekonomickeSubjektyDao.GetOneSubjectAsync(ico);

            return subject;
        }
    }
}
