using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview
{
    [DataContract(Name = "offerInfo")]
    public class OfferInfo
    {
        [DataMember(Name = "siteID")]
        public int? SiteID { get; set; } = null;
        
        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "userSelectedCurrency")]
        public string UserSelectedCurrency { get; set; }
    }
}
