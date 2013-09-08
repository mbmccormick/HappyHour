using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Tip
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string text { get; set; }
        public List<Entity> entities { get; set; }
        public string canonicalUrl { get; set; }
        public Likes2 likes { get; set; }
        public Todo todo { get; set; }
        public Done done { get; set; }
        public User user { get; set; }
        public string url { get; set; }
        public Photo photo { get; set; }
        public string photourl { get; set; }
    }
}