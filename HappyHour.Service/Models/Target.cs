using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Target
    {
        public string type { get; set; }
        public string url { get; set; }
        public Params @params { get; set; }
    }
}