using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract(Name = "hotelPricingInfo")]
    public class HotelPricingInfo
    {
        [DataMember(Name = "averagePriceValue")]
        public double AveragePriceValue { get; set; }

        [DataMember(Name = "totalPriceValue")]
        public double TotalPriceValue { get; set; }

        [DataMember(Name = "crossOutPriceValue")]
        public double CrossOutPriceValue { get; set; }

        [DataMember(Name = "originalPricePerNight")]
        public double OriginalPricePerNight { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "percentSavings")]
        public double PercentSavings { get; set; }

        [DataMember(Name = "drr")]
        public bool DRR { get; set; }
    }
}
