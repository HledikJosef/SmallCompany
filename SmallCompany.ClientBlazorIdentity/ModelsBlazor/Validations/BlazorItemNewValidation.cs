using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor.Validations
{
    public class BlazorItemNewValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var listOfProperties = value as IList<BlazorProperty>;

            var item = (BlazorItemNew?)validationContext.ObjectInstance;

            if (listOfProperties.All(prop => string.IsNullOrWhiteSpace(prop.Value)))
            {
                item!.BlazorItemPropertiesValidationMessage = "Vyplňte alespoň jednu vlastnost.";
                return new ValidationResult("");
            }

            foreach (var prop in listOfProperties)
            {
                if (!string.IsNullOrWhiteSpace(prop.Value) && prop.BlazorDateTypeId == item.BlazorDateTypes.Find(dt => dt.Name == "number").Id)
                {

                    if (!float.TryParse(prop.Value, out _))
                    {
                        item!.BlazorItemPropertiesValidationMessage = "Zkontrolujte hodnoty vlastností tam, kde má být zadáno číslo.";
                        return new ValidationResult("");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
