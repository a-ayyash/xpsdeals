using ExpediaInterview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpediaInterview.REST
{
    public class RequestManager
    {
        public static Deal GetDeal(string url)
        {
            RESTOperator RESTRequest = new RESTOperator();
            DealsJSONSerializer serializer = new DealsJSONSerializer();

            return serializer.ReadDealFromJSON(
                RESTRequest.GETContent(url));
        }
    }
}
