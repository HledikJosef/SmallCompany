using System.Text.Json;

namespace SmallCompany.ClientBlazorIdentity.ModelsBlazor.DeepCoppier
{
    public static class ObjectDeepCoppier
    {
        public static T MakeDeepCopy<T>(T sourceObject)
        {
            if (sourceObject == null)
            {
                throw new ArgumentNullException(nameof(sourceObject));
            }

            var json = JsonSerializer.Serialize(sourceObject);

            return JsonSerializer.Deserialize<T>(json)!;

        }


    }
}
