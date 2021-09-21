using Newtonsoft.Json;
using System;
using TildaNET.Converters;

namespace TildaNET.Models
{
    public class TildaPage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("projectid")]
        public string ProjectId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("descr")]
        public string Description { get; set; }
        [JsonProperty("img")]
        public string Image { get; set; }
        [JsonProperty("featureimg")]
        public string FeatureImage { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("sort")]
        public string Sort { get; set; }
        [JsonProperty("published")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Published { get; set; }
        [JsonProperty("filename")]
        public string FileName { get; set; }
        [JsonProperty("html")]
        public string Html { get; set; }
    }

}
