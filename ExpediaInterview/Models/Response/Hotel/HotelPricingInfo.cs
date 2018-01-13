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
        public double? AveragePriceValue { get; set; } = null;

        [DataMember(Name = "totalPriceValue")]
        public double? TotalPriceValue { get; set; } = null;

        [DataMember(Name = "crossOutPriceValue")]
        public double? CrossOutPriceValue { get; set; } = null;

        [DataMember(Name = "originalPricePerNight")]
        public double? OriginalPricePerNight { get; set; } = null;

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "percentSavings")]
        public double? PercentSavings { get; set; } = null;

        [DataMember(Name = "drr")]
        public bool? DRR { get; set; } = null;
    }
}
