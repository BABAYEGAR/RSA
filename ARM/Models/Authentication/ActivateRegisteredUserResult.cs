using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Authentication
{
    public class ActivateRegisteredUserResult
    {
        public string responsecode { get; set; }
        public string responsemessage { get; set; }
        public string comment { get; set; }
        public responsedata responsedata { get; set; }
        public UserProfile UserProfile { get; set; }
        public UserBalance UserBalance { get; set; }
        public PeriodBalance PeriodBalance { get; set; }
    }
}
