using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Enum
{
    public enum PaymentFrequency
    {
        Anually,
        [Display(Name = "Bi-Annually")]
        BiAnnually,
        Monthly,
        Quarterly
    }
}
