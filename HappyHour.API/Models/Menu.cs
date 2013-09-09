using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class Menu
    {
        public string type { get; set; }
        public string label { get; set; }
        public string anchor { get; set; }
        public string url { get; set; }
        public string mobileUrl { get; set; }
    }
}