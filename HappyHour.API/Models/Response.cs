using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class Response
    {
        public Meta meta { get; set; }
        public ExploreResponse response { get; set; }
        public string numResults { get; set; }
    }
}