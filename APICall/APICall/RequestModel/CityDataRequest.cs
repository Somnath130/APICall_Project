using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICall.RequestModel
{
    public class CityDataRequest
    {
   
        public string City1 { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public long? Pincode { get; set; }
        public long? AreaSqKm { get; set; }
        public string CricketStadium { get; set; }

    }
}
