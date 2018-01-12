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
        public double FlightTotalBaseFare { get; set; }

        [DataMember(Name = "flightTotalTax")]
        public double FlightTotalTax { get; set; }

        [DataMember(Name = "flightTotalPrice")]
        public double FlightTotalPrice { get; set; }

        [DataMember(Name = "flightPerPsgrBaseFare")]
        public double FlightPerPsgrBaseFare { get; set; }

        [DataMember(Name = "currencyCode")]
        public string Currency { get; set; }

        [DataMember(Name = "flightPerPsgrTax")]
        public double FlightPerPsgrTax { get; set; }

        [DataMember(Name = "flightPerPsgrBaseFarePlusTax")]
        public double FlightPerPsgrBaseFarePlusTax { get; set; }

        [DataMember(Name = "flightPerPsgrTotalPrice")]
        public double FlightPerPsgrTotalPrice { get; set; }

        [DataMember(Name = "trendAgcyFlightPrice")]
        public double TrendAgcyFlightPrice { get; set; }

        [DataMember(Name = "pctChangeFromTrend")]
        public double ChangeFromTrendPercentage { get; set; }
    }
}
