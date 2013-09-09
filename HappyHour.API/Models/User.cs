using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string photo { get; set; }
        public Tips tips { get; set; }
        public string homeCity { get; set; }
        public string bio { get; set; }
        public Contact2 contact { get; set; }
        public int? superuser { get; set; }
        public Lists lists { get; set; }
    }
}