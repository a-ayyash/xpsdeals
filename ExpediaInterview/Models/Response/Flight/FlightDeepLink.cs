using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace ExpediaInterview.Models.Response.Flight
{
    [DataContract]
    public class FlightDeepLink
    {
        private string _FlightSearchUrl;

        [DataMember(Name = "flightSearchUrl")]
        public string FlightSearchUrl { 
            get
            {
                return this._FlightSearchUrl;
            }
            set
            {
                this._FlightSearchUrl = HttpUtility.UrlDecode(value);
            }
        }
    }
}
