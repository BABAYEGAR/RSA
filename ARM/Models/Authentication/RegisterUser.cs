using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ARM.Models.Authentication
{
    public class RegisterUser
    {
        [Required]
        [DisplayName("RSA ID")]
        public string RsaId { get; set; }
        [Required]
        [DisplayName("Username")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}
