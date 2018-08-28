using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Enum
{
    public enum FundType
    {
        [Display(Name = "Fund I")]
        FundOne,
        [Display(Name = "Fund II")]
        FundTwo,
        [Display(Name = "Fund III")]
        FundThree,
        [Display(Name = "Fund IV")]
        FundFour
    }
}
