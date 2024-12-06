namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class NavigationDataModel
    {
        public BlazorItemNew? SharedBlazorItem { get; set; }

        /// <summary>
        /// Číselník
        /// </summary>
        public List<BlazorUnit> BlazorUnitsInDb = new();

        //public List<BlazorProperty> BlazorPropertiesInDb = new();
        /// <summary>
        /// Číselník
        /// </summary>
        public List<BlazorTypeOfItem> BlazorTypesOfItemInDb = new();
    }
}
