using Newtonsoft.Json;
using System.Collections.Generic;

namespace tilda.net.Models
{
    public class TildaProjectExport : TildaProject
    {  
        [JsonProperty("export_csspath")]
        public string ExportCssPath { get; set; }
        [JsonProperty("export_jspath")]
        public string ExportJsPath { get; set; }
        [JsonProperty("export_imgpath")]
        public string ExportImagePath { get; set; }
        [JsonProperty("indexpageid")]
        public string IndexPageId { get; set; }
        [JsonProperty("css")]
        public List<TildaCss> Css { get; set; }
        [JsonProperty("js")]
        public List<TildaJs> Js { get; set; }
        [JsonProperty("images")]
        public List<TildaImage> Images { get; set; }
        [JsonProperty("htaccess")]
        public string Htaccess { get; set; }
    }

    public class TildaCss
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class TildaJs
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class TildaImage
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
    }
}
