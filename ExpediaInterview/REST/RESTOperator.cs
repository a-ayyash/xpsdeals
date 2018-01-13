using ExpediaInterview.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaInterview.REST
{
    public interface IRESTable
    {
        string GETContent(string url);
    }

    public class RESTOperator : IRESTable
    {
        public string GETContent(string url)
        {
            var client = new HttpClient();

            var response = client.GetAsync(url).Result;
            var content = "";

            if (response.IsSuccessStatusCode)
            {
                var rawContent = response.Content;
                content = rawContent.ReadAsStringAsync().Result;
            }
            
            return content;
        }
    }
}
