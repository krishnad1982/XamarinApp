using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core
{
    public class News
    {
        [JsonProperty("articles")]
        public List<Articles> Articles { get; set; }
    }

    public class Articles
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
