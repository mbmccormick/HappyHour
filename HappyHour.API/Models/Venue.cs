using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHour.API.Models
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

        public string FriendlyAddress
        {
            get
            {
                return location.address + ", " + location.city + " " + location.state + " " + location.postalCode;
            }
        }

        public string FriendlyDistance
        {
            get
            {
                double value = Math.Round((location.distance / 1609.34), 2);

                if (value == 1.00)
                    return value + " mile away";
                else
                    return value + " miles away";
            }
        }

        public double FriendlyRating
        {
            get
            {
                return (rating / 2);
            }
        }
    }
}
