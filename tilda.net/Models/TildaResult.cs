using Newtonsoft.Json;

namespace tilda.net
{
    public class TildaResult<T> where T : class
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}
