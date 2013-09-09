using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class Item
    {
        public Reasons reasons { get; set; }
        public Venue venue { get; set; }
        public List<Tip> tips { get; set; }
        public string referralId { get; set; }
    }
}