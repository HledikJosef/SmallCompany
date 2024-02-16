using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Impl
{
    public class MaterialModelCreator : IMaterialModelCreator
    {


        public void CreateMaterialEntryModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties)
        {
            MaterialEntryModel materialEntryModel = new MaterialEntryModel();
            materialEntryModel.MaterialGroupName = materialGroupName;
            materialEntryModel.MaterialDescription = materialDescription;
            foreach (var property in blazorProperties)
            {
                switch (property.PropertyName)
                {
                    case "Barva":
                        materialEntryModel.MaterialColor = (bool)property.IsValid;
                        break;
                    case "Tvrdost":
                        materialEntryModel.MaterialHardness = (bool)property.IsValid;
                        break;
                    case "Hustota":
                        materialEntryModel.MaterialDensity = (bool)property.IsValid;
                        break;
                    case "Průměr":
                        materialEntryModel.MaterialDiameter = (bool)property.IsValid;
                        break;
                    case "Šířka":
                        materialEntryModel.MaterialWidth = (bool)property.IsValid;
                        break;
                    case "Délka":
                        materialEntryModel.MaterialLength = (bool)property.IsValid;
                        break;
                    case "Výška":
                        materialEntryModel.MaterialHigh = (bool)property.IsValid;
                        break;
                    case "Tloušťka":
                        materialEntryModel.MaterialThickness = (bool)property.IsValid;
                        break;
                    case "Hmotnost":
                        materialEntryModel.MaterialWeight = (bool)property.IsValid;
                        break;
                }
            }

        }


    }
}
