using ExpediaInterview.Models.Response.Flight;
using ExpediaInterview.Models.Response.Hotel;
using ExpediaInterview.Models.Response.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class PackageDetails
    {
        [DataMember(Name = "offerDateRange")]
        public OfferDateRange DateRange { get; set; }

        [DataMember(Name = "destination")]
        public PackageDestination Destination { get; set; }

        [DataMember(Name = "origin")]
        public OfferDestination Origin { get; set; }

        [DataMember(Name = "hotelInfo")]
        public HotelInfo Hotel { get; set; }

        [DataMember(Name = "hotelPricingInfo")]
        public HotelPricingInfoForPackage HotelPricing { get; set; }

        [DataMember(Name = "flightInfo")]
        public FlightInfoBase Flight { get; set; }

        [DataMember(Name = "flightPricingInfo")]
        public FlightPricingInfo FlightPricing { get; set; }

        [DataMember(Name = "packageInfo")]
        public PackageInfo Package { get; set; }

        [DataMember(Name = "packagePricingInfo")]
        public PackagePricingInfo PackagePricing { get; set; }

        [DataMember(Name = "packageUrls")]
        public PackageUrls URLs { get; set; }

        [DataMember(Name = "hotelUrgencyInfo")]
        public HotelUrgencyInfo HotelUrgency { get; set; }
    }
}
