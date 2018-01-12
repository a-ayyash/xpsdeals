using ExpediaInterview.Models.Response.Offer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract]
    public class FlightDetails
    {
        [DataMember(Name = "offerDateRange")]
        public OfferDateRange DateRange { get; set; }

        [DataMember(Name = "destination")]
        public FlightDestination Destination { get; set; }

        [DataMember(Name = "origin")]
        public OfferDestination Origin { get; set; }

        [DataMember(Name = "flightUrls")]
        public FlightDeepLink URLs { get; set; }

        [DataMember(Name = "flightPricingInfo")]
        public FlightPricingInfo PricingInfo { get; set; }

        [DataMember(Name = "flightInfo")]
        public FlightInfo Flight { get; set; }
    }
}