using ExpediaInterview.Models.Response.Flight;
using ExpediaInterview.Models.Response.Hotel;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

namespace ExpediaInterview.Models.Response.Package
{
    [DataContract]
    public class PackageUrls
    {
        private string _PackageSearchUrl;

        [DataMember(Name = "packageSearchUrl")]
        public string PackageSearchUrl { 
            get
            {
                return this._PackageSearchUrl;
            }
            set
            {
                this._PackageSearchUrl = HttpUtility.UrlDecode(value);
            }
        }

        [DataMember(Name = "flightDeeplinks")]
        public FlightDeepLink FlightDeeplinks { get; set; }

        [DataMember(Name = "hotelDeeplinks")]
        public HotelDeepLink HotelDeeplinks { get; set; }
    }
}