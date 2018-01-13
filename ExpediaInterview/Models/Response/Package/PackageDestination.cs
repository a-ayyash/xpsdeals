using ExpediaInterview.Models.Response.Offer;
using System.Runtime.Serialization;

namespace ExpediaInterview.Models.Response.Package
{
    public class PackageDestination 
    {
        [DataMember(Name = "regionId")]
        public long? RegionID { get; set; } = null;

        [DataMember(Name = "longName")]
        public string LongName { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "tla")]
        public string TLA { get; set; }

        [DataMember(Name = "metrocode")]
        public string MetroCode { get; set; }
    }
}