using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT15016508.DATA
{
    public class Post
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("userId")]
        public int userid { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("body")]
        public string body { get; set; }
    }
}
