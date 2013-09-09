using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class Likes
    {
        public int count { get; set; }
        public List<Group2> groups { get; set; }
        public string summary { get; set; }
    }
}