using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer
{
    public interface IItemModelCreator
    {
        public bool CreateItemModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties, string unit);
    }
}
