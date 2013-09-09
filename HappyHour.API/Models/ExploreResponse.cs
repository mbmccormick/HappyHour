using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class ExploreResponse
    {
        public FallbackCategory fallbackCategory { get; set; }
        public int suggestedRadius { get; set; }
        public string headerLocation { get; set; }
        public string headerFullLocation { get; set; }
        public string headerLocationGranularity { get; set; }
        public string query { get; set; }
        public int totalResults { get; set; }
        public List<Group> groups { get; set; }
    }
}