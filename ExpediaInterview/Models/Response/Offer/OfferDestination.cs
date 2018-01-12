using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Offer
{
    [DataContract(Name = "destination")]
    public class OfferDestination
    {
        [DataMember(Name = "regionId")]
        public long RegionID { get; set; }

        [DataMember(Name = "longName")]
        public string LongName { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "province")]
        public string Province { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "tla")]
        public string TLA { get; set; }
    }
}
