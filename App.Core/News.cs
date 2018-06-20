using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("urlToImage")]
        public string Image { get; set; }
        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("url")]
        public string Content { get; set; }
    }
}
