using Newtonsoft.Json;
using System.Collections.Generic;

namespace tilda.net.Models
{
    public class TildaProject
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("descr")]
        public string descr { get; set; }
        [JsonProperty("customdomain")]
        public string customdomain { get; set; }
        [JsonProperty("css")]
        public IList<string> css { get; set; }
        [JsonProperty("js")]
        public IList<string> js { get; set; }
    }
}
