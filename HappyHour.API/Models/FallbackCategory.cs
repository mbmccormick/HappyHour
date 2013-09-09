using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
{
    public class FallbackCategory
    {
        public Target target { get; set; }
        public List<Refinement> refinements { get; set; }
    }
}