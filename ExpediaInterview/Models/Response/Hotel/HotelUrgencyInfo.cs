using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract(Name = "hotelUrgencyInfo")]
    public class HotelUrgencyInfo
    {
        [DataMember(Name = "airAttachRemainingTime")]
        public int? AirAttachRemainingTime { get; set; } = null;

        [DataMember(Name = "numberOfPeopleViewing")]
        public int? NumberOfPeopleViewing { get; set; } = null;

        [DataMember(Name = "numberOfPeopleBooked")]
        public int? NumberOfPeopleBooked { get; set; } = null;

        [DataMember(Name = "numberOfRoomsLeft")]
        public int? NumberOfRoomsLeft { get; set; } = null;

        [DataMember(Name = "lastBookedTime")]
        public long? LastBookedTime { get; set; } = null;

        [DataMember(Name = "almostSoldStatus")]
        public string AlmostSoldStatus { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "airAttachEnabled")]
        public bool? AirAttachEnabled { get; set; } = null;
    }
}
