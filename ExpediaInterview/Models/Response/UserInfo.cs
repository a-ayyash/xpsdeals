using ExpediaInterview.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models
{
    [DataContract(Name = "userInfo")]
    public class UserInfo
    {
        [DataMember(Name = "userId")]
        public string UserID { get; set; }

        [DataMember(Name = "persona")]
        public Persona Persona { get; set; }
    }
}
