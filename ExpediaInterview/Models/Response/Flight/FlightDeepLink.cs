using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract]
    public class FlightDeepLink
    {
        [DataMember(Name = "flightSearchUrl")]
        public string FlightSearchUrl { get; set; }
    }
}
