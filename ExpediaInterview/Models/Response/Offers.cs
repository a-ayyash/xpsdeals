using ExpediaInterview.Models.Response.Flight;
using ExpediaInterview.Models.Response.Package;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ExpediaInterview.Models
{
    [DataContract]
    public class Offers
    {
        [DataMember(Name = "Hotel")]
        public List<HotelDetails> Hotels { get; set; }

        [DataMember(Name = "Flight")]
        public List<FlightDetails> Flights { get; set; }

        [DataMember(Name = "Package")]
        public List<PackageDetails> Packages { get; set; }
    }
}