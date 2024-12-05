using SmallCompany.ClientBlazorIdentity.ModelsBlazor.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorItemNew
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název položky musí být vyplněna a její délka musí být max 25 znaků."), MaxLength(25, ErrorMessage = "Maximální délka názvu je 25 znaků.")]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessage = "Jednotka položky musí být zvolena.")]
        [Range(0.5, 1000, ErrorMessage = "Jednotka položky musí být zvolena.")]
        public int UnitId { get; set; }

        [Required(ErrorMessage = "Typ položky musí být zvolen.")]
        [Range(0.5, 1000, ErrorMessage = "Jednotka položky musí být zvolena.")]
        public int TypeOfItemId { get; set; }
        public bool IsActive { get; set; }

        public BlazorUnit BlazorUnit { get; set; } = null!;
        public BlazorTypeOfItem BlazorTypeOfItem { get; set; } = null!;

        [BlazorItemNewValidation]
        public List<BlazorProperty> BlazorItemProperties { get; set; } = new List<BlazorProperty>();
        public List<BlazorDateType> BlazorDateTypes { get; set; } = new List<BlazorDateType>();
        public List<BlazorItemPropertyValue> BlazorItemPropertyValues { get; set; } = new List<BlazorItemPropertyValue>();

        [NotMapped]
        public string? BlazorItemPropertiesValidationMessage { get; set; }


        public BlazorItemNew CopyItem()
        {
            return new BlazorItemNew
            {
                Id = this.Id,
                Name = this.Name,
                UnitId = this.UnitId,
                TypeOfItemId = this.TypeOfItemId,
                IsActive = this.IsActive,
                BlazorUnit = this.BlazorUnit.CopyUnit(),
                BlazorTypeOfItem = this.BlazorTypeOfItem.CopyTypeOfItem(),
                BlazorItemProperties = this.BlazorItemProperties.Select(prop => prop.CopyProperty()).ToList(),
                BlazorItemPropertyValues = this.BlazorItemPropertyValues.Select(ipv => ipv.CopyItemPropertyValue()).ToList(),
            };
        }


    }
}
