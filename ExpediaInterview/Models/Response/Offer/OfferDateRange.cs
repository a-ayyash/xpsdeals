using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models
{
    [DataContract]
    public class OfferDateRange
    {

#region PRIVATE_MAPPERS

        [DataMember(Name = "travelStartDate")]
        private List<int> StartDate { get; set; }

        [DataMember(Name = "travelEndDate")]
        private List<int> EndDate { get; set; }

#endregion

#region PUBLIC_ACCESSORS

        public DateTime? TravelStartDate
        {
            get
            {
                return new DateTime(StartDate[0], StartDate[1], StartDate[2]);
            }
        }

        public DateTime? TravelEndDate
        {
            get
            {
                return new DateTime(EndDate[0], EndDate[1], EndDate[2]);
            }
        }

#endregion
    }
}