using ExpediaInterview.Models.Response.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract]
    public class FlightDestination : OfferDestination
    {
        [DataMember(Name = "metrocode")]
        public string MetroCode { get; set; }

        [DataMember(Name = "rank")]
        public int? Rank { get; set; } = null;
    }
}
