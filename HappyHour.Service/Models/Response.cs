using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Response
    {
        public Meta meta { get; set; }
        public ExploreResponse response { get; set; }
        public string numResults { get; set; }
    }
}