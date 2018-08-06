using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Authentication
{
    public class ActivateRegisteredUser
    {
        public string pin { get; set; }
        public string authenticationCode { get; set; }
    }
}
