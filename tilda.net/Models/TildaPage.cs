using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilda.net.Models
{
    public class TildaPage
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("projectid")]
        public string projectid { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("descr")]
        public string descr { get; set; }
        [JsonProperty("img")]
        public string img { get; set; }
        [JsonProperty("featureimg")]
        public string featureimg { get; set; }
        [JsonProperty("alias")]
        public string alias { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("sort")]
        public string sort { get; set; }
        [JsonProperty("published")]
        public string published { get; set; }
        [JsonProperty("filename")]
        public string filename { get; set; }
    }

}
