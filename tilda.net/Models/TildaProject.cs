using Newtonsoft.Json;
using System.Collections.Generic;

namespace tilda.net.Models
{
    public class TildaProject
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("descr")]
        public string Description { get; set; }
        [JsonProperty("customdomain")]
        public string CustomDomain { get; set; }
        [JsonProperty("css")]
        public IList<string> Css { get; set; }
        [JsonProperty("js")]
        public IList<string> Js { get; set; }
    }
}
