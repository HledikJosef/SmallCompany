using SmallCompany.Models;

namespace SmallCompany.ServiceLayer.Implementation
{
    internal static class StringModifier
    {
        public static string ModifyString(string value)
        {
            string valueToLower = value.ToLower().Trim();
            value = valueToLower;

            return value;

        }

        public static string ModifyString(ItemPropertyValue ipv)
        {
            if (ipv.Property.DateType.Name == "number")
            {
                string modifiedNr = ipv.Value.Replace('.', ',');
                ipv.Value = modifiedNr;
            }

            return ipv.Value;
        }
    }
}
