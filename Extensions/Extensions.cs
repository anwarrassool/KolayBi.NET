using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KolayBi.Net.Extensions;

public static class DictionaryExtensions
{
    public static Dictionary<string, object> FlattenDictionary(this Dictionary<string, object> dictionary)
    {
        var result = new Dictionary<string, object>();

        void FlattenRecursive(JObject source, string prefix)
        {
            foreach (var kvp in source)
            {
                var key = string.IsNullOrEmpty(prefix) ? kvp.Key : $"{prefix}[{kvp.Key}]";

                if (kvp.Value is JObject nestedObject)
                {
                    FlattenRecursive(nestedObject, key);
                }
                else if (kvp.Value is JArray array)
                {
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] is JObject nestedObjectInArray)
                        {
                            FlattenRecursive(nestedObjectInArray, $"{key}[{i}]");
                        }
                        else
                        {
                            result[$"{key}[{i}]"] = ConvertToNativeType(array[i]);

                        }
                    }
                }
                else
                {
                    result[key] = ConvertToNativeType(kvp.Value);
                }
            }
        }

        object ConvertToNativeType(object value)
        {
            if (value is JValue jValue)
            {
                return jValue.Value;
            }
            return value;
        }

        var jObject = JObject.FromObject(dictionary);
        FlattenRecursive(jObject, string.Empty);
        return result;
    }
}

public static class TExtensions
{
    public static Dictionary<string, object> FormDictionary<T>(this T request)
    {
        return JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(request)).FlattenDictionary();
    }
}