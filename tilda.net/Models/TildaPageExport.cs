﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TildaNET.Models
{
    public class TildaPageExport : TildaPage
    {
        [JsonProperty("images")]
        public IList<TildaImage> Images { get; set; }
        [JsonProperty("html")]
        public string Html { get; set; }
    }

}
