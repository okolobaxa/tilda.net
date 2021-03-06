﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TildaNET.Models
{
    public class TildaProjectExport
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("descr")]
        public string Description { get; set; }
        [JsonProperty("customdomain")]
        public string CustomDomain { get; set; }
        [JsonProperty("export_csspath")]
        public string ExportCssPath { get; set; }
        [JsonProperty("export_jspath")]
        public string ExportJsPath { get; set; }
        [JsonProperty("export_imgpath")]
        public string ExportImagePath { get; set; }
        [JsonProperty("indexpageid")]
        public string IndexPageId { get; set; }
        [JsonProperty("css")]
        public IList<TildaCss> Css { get; set; }
        [JsonProperty("js")]
        public IList<TildaJs> Js { get; set; }
        [JsonProperty("images")]
        public IList<TildaImage> Images { get; set; }
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
