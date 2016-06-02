using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TildaNET
{
    internal class TildaResult<T> where T : class
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TildaResultStatus Status { get; set; }
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}
