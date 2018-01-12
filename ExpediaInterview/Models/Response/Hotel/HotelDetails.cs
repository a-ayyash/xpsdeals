using ExpediaInterview.Models.Response.Hotel;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models
{
    [DataContract(Name = "hotelOffer")]
    public class HotelDetails
    {
        [DataMember(Name = "offerDateRange")]
        public HotelDateRange DateRange { get; set; }

        [DataMember(Name = "destination")]
        public HotelDestination Destination { get; set; }

        [DataMember(Name = "hotelInfo")]
        public HotelInfo Hotel { get; set; }

        [DataMember(Name = "hotelUrgencyInfo")]
        public HotelUrgencyInfo Urgency { get; set; }

        [DataMember(Name = "hotelPricingInfo")]
        public HotelPricingInfo Pricing { get; set; }

        [DataMember(Name = "hotelUrls")]
        public HotelURLs URLs { get; set; }
    }
}
