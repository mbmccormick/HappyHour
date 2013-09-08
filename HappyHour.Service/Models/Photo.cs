﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class Photo
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Source source { get; set; }
        public string url { get; set; }
        public Sizes sizes { get; set; }
    }
}