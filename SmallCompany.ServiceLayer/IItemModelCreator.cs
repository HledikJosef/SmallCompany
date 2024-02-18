using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemModelCreator
    {
        public bool CreateItemEntryModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties);
    }
}
