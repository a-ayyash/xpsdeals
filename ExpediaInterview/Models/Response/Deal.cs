using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models
{
    [DataContract(Name = "deal")]
    public class Deal
    {
        [DataMember(Name ="offerInfo")]
        public OfferInfo OfferDetails { get; set; }

        [DataMember(Name = "userInfo")]
        public UserInfo User { get; set; }


        [DataMember(Name = "offers")]
        public Offers OfferCollections { get; set; }

        internal static Deal InvalidDeal()
        {
            return new Deal();
        }

        public bool IsValidDeal()
        {
            return OfferDetails != null && User != null && OfferCollections != null;
        }
    }
}
