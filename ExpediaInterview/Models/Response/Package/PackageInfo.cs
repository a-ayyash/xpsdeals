using System;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class PackageInfo
    {
        [DataMember(Name = "brandedDealsIdentifier")]
        public string BrandedDealsIdentifier { get; set; }
    }
}