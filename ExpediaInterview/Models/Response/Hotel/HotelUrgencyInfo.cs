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
        public int AirAttachRemainingTime { get; set; }

        [DataMember(Name = "numberOfPeopleViewing")]
        public int NumberOfPeopleViewing { get; set; }

        [DataMember(Name = "numberOfPeopleBooked")]
        public int NumberOfPeopleBooked { get; set; }

        [DataMember(Name = "numberOfRoomsLeft")]
        public int NumberOfRoomsLeft { get; set; }

        [DataMember(Name = "lastBookedTime")]
        public long LastBookedTime { get; set; }

        [DataMember(Name = "almostSoldStatus")]
        public string AlmostSoldStatus { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "airAttachEnabled")]
        public bool AirAttachEnabled { get; set; }
    }
}
