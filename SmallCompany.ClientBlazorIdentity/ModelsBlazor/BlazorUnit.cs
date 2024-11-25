using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class BlazorUnit
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Název musí být vyplněn a jeho délka musí být do 15 znaků."), MaxLength(15, ErrorMessage = "Délka názvu musí být max 15 znaků.")]
        public string Name { get; set; } = String.Empty;
        public bool IsActive { get; set; }
    }
}
