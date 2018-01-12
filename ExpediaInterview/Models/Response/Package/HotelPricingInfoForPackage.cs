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
        public double HotelPerPsgrBaseRate { get; set; }

        [DataMember(Name = "hotelPerPsgrTaxesAndFees")]
        public double HotelPerPsgrTaxesAndFees { get; set; }

        [DataMember(Name = "hotelPerPsgrTotalRate")]
        public double HotelPerPsgrTotalRate { get; set; }

        [DataMember(Name = "hotelTotalBaseRate")]
        public double HotelTotalBaseRate { get; set; }

        [DataMember(Name = "hotelTotalRate")]
        public double HotelTotalRate { get; set; }

        [DataMember(Name = "hotelTotalTaxesAndFees")]
        public double HotelTotalTaxesAndFees { get; set; }

        [DataMember(Name = "drr")]
        public bool DRR { get; set; }
    }
}