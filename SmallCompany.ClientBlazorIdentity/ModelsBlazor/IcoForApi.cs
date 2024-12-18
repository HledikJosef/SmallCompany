using System.ComponentModel.DataAnnotations;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor
{
    public class IcoForApi
    {
        [Required(ErrorMessage = "Ičo musí být vyplněno."),
         RegularExpression(@"^\d+$", ErrorMessage = "Hodnota musí obsahovat pouze číslice.")]
        public string Ico { get; set; } = string.Empty;
    }
}
