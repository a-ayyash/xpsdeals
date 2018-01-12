using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ExpediaInterview.ViewModel
{
    public class QueryParametersViewModel
    {
        [Required]
        [Display(Name = "Scenario")]
        public string scenario { get; set; }

        [Required]
        [Display(Name = "Page")]
        public string page { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public string uid { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public string productType { get; set; }


        public IDictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> paramsDictionary = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(QueryParametersViewModel).GetProperties();
            foreach (var property in properties)
            {
                paramsDictionary.Add(property.Name, property.GetValue(this).ToString());
            }
            return paramsDictionary;
        }

    }
}
