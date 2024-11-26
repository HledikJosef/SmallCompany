using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorTypeOfItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název datového typu musí být vyplněn a jeho délka musí být max 15 znaků."), MaxLength(15, ErrorMessage = "Maximální délka musí být 15 znaků.")]
        public string Name { get; set; } = String.Empty;
        public bool IsActive { get; set; }


        public BlazorTypeOfItem CopyTypeOfItem()
        {
            return (BlazorTypeOfItem)MemberwiseClone();
        }

    }
}
