using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Group
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<Item> items { get; set; }
    }
}