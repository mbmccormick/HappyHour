﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class Group
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<Item> items { get; set; }
    }
}