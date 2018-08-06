using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Authentication
{
    public class UserProfile
    {
    public string RsaID { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string DoB { get; set; }
        public string Sex { get; set; }
        public string Marital { get; set; }
        public string EmployerNo { get; set; }
        public string EmployerName { get; set; }
        public string EECont { get; set; }
        public string EEAdditional { get; set; }
        public string ERCont { get; set; }
        public string ERAdditional { get; set; }
        public string TotalCont { get; set; }
        public string RsaBalance { get; set; }
        public string AVCBalance { get; set; }
        public string LastRSADate { get; set; }
        public string LastAVCDate { get; set; }
    }
}
