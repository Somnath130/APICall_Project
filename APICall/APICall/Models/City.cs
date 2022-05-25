using System;
using System.Collections.Generic;

namespace APICall.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string City1 { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public long? Pincode { get; set; }
        public long? AreaSqKm { get; set; }
        public string CricketStadium { get; set; }
    }
}
