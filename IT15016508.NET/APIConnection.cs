using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                if (!string.IsNullOrEmpty(json))
                    posts = JsonConvert.DeserializeObject<Post[]>(json).ToList();
            }
            return posts;
        }

        public static List<Comment> GetComments(int id) {
            List<Comment> comments = new List<Comment>();
            using (WebClient client = new WebClient()) {
                string json = client.DownloadString("https://jsonplaceholder.typicode.com/comments?postId="+id);
                if (!string.IsNullOrEmpty(json))
                    comments = JsonConvert.DeserializeObject<Comment[]>(json).ToList();
            }
            return comments;
        }

        public static User GetUser(int id) {
            User user = new User();
            using (WebClient client = new WebClient()) {
                string json = client.DownloadString("https://jsonplaceholder.typicode.com/users?id=" + id);
                if (!string.IsNullOrEmpty(json))
                {
                    List<User> users = JsonConvert.DeserializeObject<User[]>(json).ToList();
                    if (users.Count > 0)
                        user = users[0];
                }
            }
            return user;
        }
    }
}
