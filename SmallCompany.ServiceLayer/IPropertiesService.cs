using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IPropertiesService
    {
        List<PropertiesBlazorModel> GetBlazorProperties();
    }
}
