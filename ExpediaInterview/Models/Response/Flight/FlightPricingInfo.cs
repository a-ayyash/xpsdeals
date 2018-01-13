using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract(Name = "hotelPricingInfo")]
    public class FlightPricingInfo
    {
        [DataMember(Name = "flightTotalBaseFare")]
        public double? FlightTotalBaseFare { get; set; } = null;

        [DataMember(Name = "flightTotalTax")]
        public double? FlightTotalTax { get; set; } = null;

        [DataMember(Name = "flightTotalPrice")]
        public double? FlightTotalPrice { get; set; } = null;

        [DataMember(Name = "flightPerPsgrBaseFare")]
        public double? FlightPerPsgrBaseFare { get; set; } = null;

        [DataMember(Name = "currencyCode")]
        public string Currency { get; set; }

        [DataMember(Name = "flightPerPsgrTax")]
        public double? FlightPerPsgrTax { get; set; } = null;

        [DataMember(Name = "flightPerPsgrBaseFarePlusTax")]
        public double? FlightPerPsgrBaseFarePlusTax { get; set; } = null;

        [DataMember(Name = "flightPerPsgrTotalPrice")]
        public double? FlightPerPsgrTotalPrice { get; set; } = null;

        [DataMember(Name = "trendAgcyFlightPrice")]
        public double? TrendAgencyFlightPrice { get; set; } = null;

        [DataMember(Name = "pctChangeFromTrend")]
        public double? ChangeFromTrendPercentage { get; set; } = null;
    }
}
