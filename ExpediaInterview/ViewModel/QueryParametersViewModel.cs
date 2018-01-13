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
        [StringLength(60, MinimumLength = 3)]
        public string Scenario { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Page { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Uid { get; set; }

        public string ProductType { get; set; }
        public string DestinationName { get; set; }
        public string DestinationCity { get; set; }
        public string MinTripStartDate { get; set; }
        public string MaxTripStartDate { get; set; }
        public string LengthOfStay { get; set; }
        public string MinStarRating { get; set; }
        public string MaxStarRating { get; set; }
        public string MinGuestRating { get; set; }
        public string MaxGuestRating { get; set; }
        public string MinTotalRate { get; set; }
        public string MaxTotalRate { get; set; }


        public IDictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> paramsDictionary = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(QueryParametersViewModel).GetProperties();
            foreach (var property in properties)
            {
                var name = property.Name;
                var value = property.GetValue(this);

                if (value == null)
                {
                    continue;
                }

                paramsDictionary.Add(char.ToLower(name[0]) + name.Substring(1), value.ToString());
            }
            return paramsDictionary;
        }

        internal static QueryParametersViewModel GetDefaults()
        {
            QueryParametersViewModel defaults = new QueryParametersViewModel();
            defaults.Page = "foo";
            defaults.Uid = "foo";
            defaults.Scenario = "deal-finder";

            return defaults;
        }
    }
}
