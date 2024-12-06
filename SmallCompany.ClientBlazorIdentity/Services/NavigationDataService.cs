using SmallCompany.ClientBlazorIdentity.ModelsBlazor;

namespace SmallCompany.ClientBlazorIdentity.Services
{
    public class NavigationDataService
    {
        public BlazorItemNew? SharedBlazorItem { get; set; }

        public List<BlazorUnit> BlazorUnitsInDb = new();
        public List<BlazorProperty> BlazorPropertiesInDb = new();
        public List<BlazorTypeOfItem> BlazorTypesOfItemInDb = new();


    }
}
