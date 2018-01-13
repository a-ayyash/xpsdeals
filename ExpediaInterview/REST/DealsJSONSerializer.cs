using ExpediaInterview.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpediaInterview.REST
{
    public class DealsJSONSerializer
    {
        public static Deal ReadDealFromJSON(string content)
        {
            if (String.IsNullOrEmpty(content))
            {
                return Deal.InvalidDeal();
            }

            return JsonConvert.DeserializeObject<Deal>(content);
        }
    }
}
