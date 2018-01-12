using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract(Name = "hotelUrls")]
    public class HotelURLs : HotelDeepLink
    {
        [DataMember(Name = "hotelSearchResultUrl")]
        public string HotelSearchResultUrl { get; set; }
    }

    public class HotelDeepLink
    {
        [DataMember(Name = "hotelInfositeUrl")]
        public string HotelInfositeUrl { get; set; }
    }
}
