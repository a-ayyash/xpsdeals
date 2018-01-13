using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpediaInterview.ViewModel;

namespace ExpediaInterview.REST
{
    public class TargetURL
    {
        public static string GenerateURL(IDictionary<string, string> QueryParameters)
        {
            var baseURL = "https://offersvc.expedia.com/offers/v2/getOffers?";

            foreach (var p in QueryParameters)
            {
                baseURL += p.Key + "=" + p.Value + "&";
            }
            return baseURL.TrimEnd('&');
        }

        public static string GenerateDefaultURL()
        {
            return "https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo";
        }
    }
}
