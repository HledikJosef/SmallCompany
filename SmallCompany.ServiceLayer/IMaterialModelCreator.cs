using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IMaterialModelCreator
    {
        public void CreateMaterialEntryModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties);
    }
}
