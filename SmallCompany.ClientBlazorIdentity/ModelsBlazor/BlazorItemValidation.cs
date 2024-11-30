using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorItemValidation : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var item = (BlazorItem?)validationContext.ObjectInstance;

            if (item.BlazorItemProperties.All(prop => string.IsNullOrWhiteSpace(prop.Value)))
            {
                return new ValidationResult("Musí být vyplněna alespoň jedna vlastnost.");
            }

            foreach (var prop in item.BlazorItemProperties)
            {
                if (!string.IsNullOrWhiteSpace(prop.Value) && prop.Id == item.BlazorDateTypes.Find(dt => dt.Name == "number").Id)
                {
                    if (!float.TryParse(prop.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
                    {
                        return new ValidationResult("Tato hodnota musí být číslo.");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
