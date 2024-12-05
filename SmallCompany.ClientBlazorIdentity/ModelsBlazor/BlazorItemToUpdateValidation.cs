using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor

{
    public class BlazorItemToUpdateValidation : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var listOfIpv = value as IList<BlazorItemPropertyValue?>;

            var blazorItemToUpdate = (BlazorItemToUpdate?)validationContext.ObjectInstance;

            if (listOfIpv.Any(ipv => string.IsNullOrWhiteSpace(ipv.Value)))
            {
                blazorItemToUpdate!.BlazorItemUpdateValidationMessage = "Vyplňte všechny požadované vlastnosti nebo založte zcela novou položku.";
                return new ValidationResult("");
            }

            foreach (var ipv in listOfIpv)
            {
                if (FindPropertyValueWithValueTypeOfNumber(ipv.BlazorProperty) && !float.TryParse(ipv.Value, out _))
                {
                    blazorItemToUpdate!.BlazorItemUpdateValidationMessage = "Zde vyplňte číslo.";
                    return new ValidationResult("");
                }
            }


            return ValidationResult.Success;
        }

        private bool FindPropertyValueWithValueTypeOfNumber(BlazorProperty blazorProperty)
        {
            bool isNumberType = false;

            if (blazorProperty.BlazorDateType.Name == "number")
            {
                isNumberType = true;
            }


            return isNumberType;
        }
    }
}
