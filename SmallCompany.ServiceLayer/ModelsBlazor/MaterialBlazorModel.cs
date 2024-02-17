using System.ComponentModel;

namespace SmallCompany.ServiceLayer.ModelsBlazor
{
    public enum MaterialDescription
    {
        [Description("Materiál")]
        materiál,
        [Description("Výrobek")]
        výrobek,
        [Description("Polotovar")]
        polotovar,
        [Description("Zboží")]
        zboží
    }
}
