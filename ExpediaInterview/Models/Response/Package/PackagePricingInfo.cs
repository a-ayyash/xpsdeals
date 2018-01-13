using System;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class PackagePricingInfo
    {
        [DataMember(Name = "perPsgrPackagePrice")]
        public double? PerPsgrPackagePrice { get; set; } = null;

        [DataMember(Name = "totalPackagePrice")]
        public double? TotalPackagePrice { get; set; } = null;

        [DataMember(Name = "perPsgrSavings")]
        public double? PerPsgrSavings { get; set; } = null;

        [DataMember(Name = "totalSavings")]
        public double? TotalSavings { get; set; } = null;

        [DataMember(Name = "currencyCode")]
        public string Currency { get; set; }

        [DataMember(Name = "percentSavings")]
        public double? PercentSavings { get; set; } = null;

        [DataMember(Name = "savingsPctOfHotel")]
        public double? SavingsPctOfHotel { get; set; } = null;

        [DataMember(Name = "savingsPctOfFlight")]
        public double? SavingsPctOfFlight { get; set; } = null;
    }
}