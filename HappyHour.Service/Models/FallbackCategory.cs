using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyHour.Service.Models
{
    public class FallbackCategory
    {
        public Target target { get; set; }
        public List<Refinement> refinements { get; set; }
    }
}