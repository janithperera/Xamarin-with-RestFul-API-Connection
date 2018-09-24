using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using IT15016508.DATA;
using Newtonsoft.Json;

namespace IT15016508.NET
{
    public class APIConnection
    {
        public static List<Post> GetPosts() {
            List<Post> posts = new List<Post>();
            using (WebClient client = new WebClient()) {
                string json = client.DownloadString("https://jsonplaceholder.typicode.com/posts");
                if (!string.IsNullOrEmpty(json)) {
                    posts = JsonConvert.DeserializeObject<Post[]>(json).ToList();
                }
            }
            return posts;
        }
    }
}
