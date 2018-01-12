using ExpediaInterview.Models.Response.Flight;
using ExpediaInterview.Models.Response.Hotel;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class PackageUrls
    {
        [DataMember(Name = "packageSearchUrl")]
        public string PackageSearchUrl { get; set; }

        [DataMember(Name = "flightDeeplinks")]
        public FlightDeepLink FlightDeeplinks { get; set; }

        [DataMember(Name = "hotelDeeplinks")]
        public HotelDeepLink HotelDeeplinks { get; set; }
    }
}