using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract]
    public class HotelDateRange : OfferDateRange
    {
        [DataMember(Name = "lengthOfStay")]
        public int? LengthOfStay { get; set; } = null;
    }
}
