using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract(Name = "hotelInfo")]
    public class HotelInfo
    {
        [DataMember(Name = "hotelId")]
        public long? ID { get; set; } = null;

        [DataMember(Name = "hotelName")]
        public string Name { get; set; }

        [DataMember(Name = "localizedHotelName")]
        public string LocalizedName { get; set; }

        [DataMember(Name = "hotelDestination")]
        public string Destination { get; set; }

        [DataMember(Name = "hotelDestinationRegionID")]
        public long? DestinationRegionID { get; set; } = null;

        [DataMember(Name = "hotelLongDestination")]
        public string LongDestination { get; set; }

        [DataMember(Name = "hotelStreetAddress")]
        public string StreetAddress { get; set; }

        [DataMember(Name = "hotelCity")]
        public string City { get; set; }

        [DataMember(Name = "hotelProvince")]
        public string Province { get; set; }

        [DataMember(Name = "hotelCountryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "hotelLatitude")]
        public double? Latitude { get; set; } = null;

        [DataMember(Name = "hotelLongitude")]
        public double? Longitude { get; set; } = null;

        [DataMember(Name = "hotelStarRating")]
        public double? StarRating { get; set; } = null;

        [DataMember(Name = "hotelGuestReviewRating")]
        public double? GuestReviewRating { get; set; } = null;

        [DataMember(Name = "hotelReviewTotal")]
        public double? ReviewTotal { get; set; } = null;

        [DataMember(Name = "hotelImageUrl")]
        public string ImageUrl { get; set; }

        [DataMember(Name = "vipAccess")]
        public bool? VipAccess { get; set; } = null;

        [DataMember(Name = "isOfficialRating")]
        public bool? IsOfficialRating { get; set; } = null;
    }
}
