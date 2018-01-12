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
        public Deal ReadDealFromJSON(string content)
        {
            if (String.IsNullOrEmpty(content))
            {
                throw new InvalidDataException("JSON string can't be empty nor null");
            }

            return JsonConvert.DeserializeObject<Deal>(content);
        }
    }
}
