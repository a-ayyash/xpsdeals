using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

namespace ExpediaInterview.Models.Response.Hotel
{
    [DataContract]
    public class HotelURLs : HotelDeepLink
    {
        private string _HotelSearchResultUrl;

        [DataMember(Name = "hotelSearchResultUrl")]
        public string HotelSearchResultUrl {
            get
            {
                return this._HotelSearchResultUrl;
            }
            set
            {
                this._HotelSearchResultUrl = HttpUtility.UrlDecode(value);
            }
        }
    }

    [DataContract]
    public class HotelDeepLink
    {
        protected string _HotelInfositeUrl;

        [DataMember(Name = "hotelInfositeUrl")]
        public string HotelInfositeUrl {
            get
            {
                return this._HotelInfositeUrl;
            }
            set {
                this._HotelInfositeUrl = HttpUtility.UrlDecode(value);
            }
        }
    }
}
