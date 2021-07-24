using System.Text.Json;

namespace Ardalis.Extensions.Serialization.Json
{
    public static partial class JsonExtensionMethods
    {
        /// <summary>
        /// Converts a Type to a JSON string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ToJson<T>(this T t)
        {
            var value = JsonSerializer.Serialize(t);

            return value;
        }
    }
}