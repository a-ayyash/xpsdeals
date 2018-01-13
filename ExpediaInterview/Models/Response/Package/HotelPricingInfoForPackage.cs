using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class HotelPricingInfoForPackage
    {
        [DataMember(Name = "hotelPerPsgrBaseRate")]
        public double? HotelPerPsgrBaseRate { get; set; } = null;

        [DataMember(Name = "hotelPerPsgrTaxesAndFees")]
        public double? HotelPerPsgrTaxesAndFees { get; set; } = null;

        [DataMember(Name = "hotelPerPsgrTotalRate")]
        public double? HotelPerPsgrTotalRate { get; set; } = null;

        [DataMember(Name = "hotelTotalBaseRate")]
        public double? HotelTotalBaseRate { get; set; } = null;

        [DataMember(Name = "hotelTotalRate")]
        public double? HotelTotalRate { get; set; } = null;

        [DataMember(Name = "hotelTotalTaxesAndFees")]
        public double? HotelTotalTaxesAndFees { get; set; } = null;

        [DataMember(Name = "drr")]
        public bool? DRR { get; set; } = null;
    }
}