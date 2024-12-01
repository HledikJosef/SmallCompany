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
                if (FindPropertyValueWithValueTypeOfNumber(ipv, blazorItemToUpdate) && float.TryParse(ipv.Value, out _))
                {
                    blazorItemToUpdate!.BlazorItemUpdateValidationMessage = "Zde vyplňte číslo.";
                    return new ValidationResult("");
                }
            }



            return ValidationResult.Success;
        }

        private bool FindPropertyValueWithValueTypeOfNumber(BlazorItemPropertyValue blazorItemPropertyValue, BlazorItemToUpdate blazorItemToUpdate)
        {
            bool isNumerType = false;
            int dateTypeOfNumberId = blazorItemToUpdate.BlazorDateTypes.Find(dt => dt.Name == "number").Id;

            if (blazorItemPropertyValue.BlazorPropertyId == blazorItemToUpdate.BlazorItemProperties.Find(prop => prop.BlazorDateTypeId == dateTypeOfNumberId).Id)
            {
                isNumerType = true;
            }


            return isNumerType;
        }
    }
}
