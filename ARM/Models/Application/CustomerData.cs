using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Application
{
    public class CustomerData : Transport
    {
        public long CustomerDataId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "This field is does not support more than 100 characters")]
        [RegularExpression("[a-zA-Z ]*$")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "This field is does not support more than 100 characters")]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(100, ErrorMessage = "This field is does not support more than 100 characters")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "This field must contain only digits")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public long Rating { get; set; }
    }
}
