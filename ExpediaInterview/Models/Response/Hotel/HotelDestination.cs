using ExpediaInterview.Models.Response.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract]
    public class HotelDestination : OfferDestination
    {
        [DataMember(Name = "associatedMultiCityRegionId")]
        public long AssociatedMultiCityRegionId { get; set; }

        [DataMember(Name = "nonLocalizedCity")]
        public string NonLocalizedCity { get; set; }

        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }
    }
}
