using System.Globalization;

namespace SmallCompany.ServiceLayer.Implementation
{
    internal static class StringModifier
    {
        public static string ModifyString(string value)
        {
            string valueToLower = value.ToLower();
            value = valueToLower;

            if (float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedFloatValue))
            {
                string modifiedNr = value.Replace('.', ',');
                value = modifiedNr;
            }

            return value;

        }
    }
}
