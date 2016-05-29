using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilda.net.Models
{
    public class TildaCss
    {
        [JsonProperty("from")]
        public string from { get; set; }
        [JsonProperty("to")]
        public string to { get; set; }
    }

    public class TildaJs
    {
        [JsonProperty("from")]
        public string from { get; set; }
        [JsonProperty("to")]
        public string to { get; set; }
    }

    public class TildaImage
    {
        [JsonProperty("from")]
        public string from { get; set; }
        [JsonProperty("to")]
        public string to { get; set; }
    }

    public class TildaProjectExport
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("descr")]
        public string descr { get; set; }
        [JsonProperty("customdomain")]
        public string customdomain { get; set; }
        [JsonProperty("export_csspath")]
        public string export_csspath { get; set; }
        [JsonProperty("export_jspath")]
        public string export_jspath { get; set; }
        [JsonProperty("export_imgpath")]
        public string export_imgpath { get; set; }
        [JsonProperty("indexpageid")]
        public string indexpageid { get; set; }
        [JsonProperty("css")]
        public IList<TildaCss> css { get; set; }
        [JsonProperty("js")]
        public IList<TildaJs> js { get; set; }
        [JsonProperty("images")]
        public IList<TildaImage> images { get; set; }
        [JsonProperty("htaccess")]
        public string htaccess { get; set; }
    }
}
