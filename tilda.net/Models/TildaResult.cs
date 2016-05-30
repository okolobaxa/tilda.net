using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tilda.net
{
    public class TildaResult<T> where T : class
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ETildaResultStatus Status { get; set; }
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}
