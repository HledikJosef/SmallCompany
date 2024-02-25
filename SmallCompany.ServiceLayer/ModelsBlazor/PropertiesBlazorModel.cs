namespace SmallCompany.ServiceLayer.ModelsBlazor
{

    public class PropertiesBlazorModel
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string PropertyDescription { get; set; }
        public bool IsValid { get; set; } = false;


    }


}
