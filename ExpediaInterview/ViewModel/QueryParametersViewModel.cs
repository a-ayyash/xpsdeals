using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ExpediaInterview.ViewModel
{

    public class DateStringAttribute : ValidationAttribute
    {
        private string _dateFormat;

        public DateStringAttribute(string dateFormat)
        {
            _dateFormat = dateFormat;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;

            }

            try
            {
                DateTime dt = DateTime.ParseExact(value.ToString(), _dateFormat, System.Globalization.CultureInfo.InvariantCulture);

                return ValidationResult.Success;
            }
            catch(ArgumentNullException e)
            {
                return new ValidationResult(e.Message);
            }
            catch(FormatException e)
            {
                return new ValidationResult(e.Message);
            }
        }
    }

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

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Destination City")]
        public string DestinationCity { get; set; }

        [DateStringAttribute("yyyy-MM-dd")]
        [Display(Name = "Minimum Trip Start Date")]
        public string MinTripStartDate { get; set; }

        [DateStringAttribute("yyyy-MM-dd")]
        [Display(Name = "Maximum Trip Start Date")]
        public string MaxTripStartDate { get; set; }

        [Range(1, 100, ErrorMessage = "Stay must be a number between 1 and 100 days")]
        [Display(Name = "Length Of Stay")]
        public string LengthOfStay { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Minimum Star Rating")]
        public string MinStarRating { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Max Star Rating")]
        public string MaxStarRating { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Min Guest Rating")]
        public string MinGuestRating { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Max Guest Rating")]
        public string MaxGuestRating { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Min Total Rating")]
        public string MinTotalRate { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating must be a number betweein 0.0 and 5.0")]
        [Display(Name = "Max Total Rating")]
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
