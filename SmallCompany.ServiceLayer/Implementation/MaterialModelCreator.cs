using SmallCompany.DataLayer;
using SmallCompany.DataLayer.Models;
using SmallCompany.ServiceLayer.ModelsBlazor;

namespace SmallCompany.ServiceLayer.Impl
{
    public class MaterialModelCreator : IMaterialModelCreator
    {
        private readonly IDBRecordWriter dBRecordWriter;

        public MaterialModelCreator(IDBRecordWriter dBRecordWriter)
        {
            this.dBRecordWriter = dBRecordWriter;
        }


        public void CreateMaterialEntryModel(string materialGroupName, string materialDescription, List<PropertiesBlazorModel> blazorProperties)
        {
            MaterialModel materialModel = new MaterialModel();
            materialModel.MaterialGroupName = materialGroupName;
            materialModel.MaterialDescription = materialDescription;
            foreach (var property in blazorProperties)
            {
                switch (property.PropertyName)
                {
                    case "Barva":
                        materialModel.MaterialColor = (bool)property.IsValid;
                        break;
                    case "Tvrdost":
                        materialModel.MaterialHardness = (bool)property.IsValid;
                        break;
                    case "Hustota":
                        materialModel.MaterialDensity = (bool)property.IsValid;
                        break;
                    case "Průměr":
                        materialModel.MaterialDiameter = (bool)property.IsValid;
                        break;
                    case "Šířka":
                        materialModel.MaterialWidth = (bool)property.IsValid;
                        break;
                    case "Délka":
                        materialModel.MaterialLength = (bool)property.IsValid;
                        break;
                    case "Výška":
                        materialModel.MaterialHigh = (bool)property.IsValid;
                        break;
                    case "Tloušťka":
                        materialModel.MaterialThickness = (bool)property.IsValid;
                        break;
                    case "Hmotnost":
                        materialModel.MaterialWeight = (bool)property.IsValid;
                        break;

                }
                materialModel.IsValid = true;
            }
            dBRecordWriter.WriteMaterialModel(materialModel);

        }


    }
}
