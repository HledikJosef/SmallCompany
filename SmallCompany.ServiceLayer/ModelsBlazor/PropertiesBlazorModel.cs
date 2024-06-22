namespace SmallCompany.ServiceLayer.ModelsBlazor
{

    public class PropertiesBlazorModel
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; } = string.Empty;
        public string PropertyType { get; set; } = string.Empty;
        public string PropertyDescription { get; set; } = string.Empty;
        public bool IsValid { get; set; } = false;


    }


}
