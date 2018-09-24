using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT15016508.DATA
{
    public class Comment
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "postId")]
        public int postid { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }
        [JsonProperty(PropertyName = "body")]
        public string body { get; set; }
    }
}
