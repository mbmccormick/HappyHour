﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public string canonicalUrl { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public bool restricted { get; set; }
        public Stats stats { get; set; }
        public string url { get; set; }
        public Likes likes { get; set; }
        public double rating { get; set; }
        public Reservations reservations { get; set; }
        public Menu menu { get; set; }
        public Hours hours { get; set; }
        public List<object> specials { get; set; }
        public Photos photos { get; set; }
        public HereNow hereNow { get; set; }
        public Price price { get; set; }
        public string storeId { get; set; }
    }
}