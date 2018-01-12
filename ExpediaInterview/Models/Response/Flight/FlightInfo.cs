using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract]
    public class FlightInfoBase
    {
        [DataMember(Name = "flightDealCarrier")]
        public string FlightCarrierShortName { get; set; }

        [DataMember(Name = "lengthOfStay")]
        public int LengthOfStay { get; set; }

        [DataMember(Name = "tripType")]
        public string TripType { get; set; }
    }

    [DataContract]
    public class FlightInfo : FlightInfoBase
    {
        [DataMember(Name = "flightDealCarrierName")]
        public string FlightCarrierName { get; set; }

        [DataMember(Name = "lastObservedDate")]
        public DateTime LastObservedDate { get; set; }
    }
}
