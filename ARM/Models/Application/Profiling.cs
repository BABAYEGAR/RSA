using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ARM.Models.Application
{
    public class Profiling
    {
        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("When were you born?")]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Are you male or female?")]
        [Required(ErrorMessage = "The field is required!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("What is your marital status ?")]
        public string MartitalStatus { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("At what age do you plan to stop working? (If you've already left the workforce, please tell us the age at which you stopped working.")]
        public long RetirementAge { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("What is you annual earning before tax?")]
        public decimal AnnualSalary { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Monthly Employee Contribution")]
        [DefaultValue(0.00)]
        public decimal MonthlyEmployeeContribution { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Monthly Employer Contribution")]
        [DefaultValue(0.00)]
        public decimal MonthlyEmployerContribution { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public decimal TargetIncome { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Do you have a Retirement Savings Account?")]
        public string RsaAccount { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Are you registered with ARM Pensions?")]
        public string ArmPensionRegistered { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Will you own a Home at retirement?")]
        public string RetirementHome { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Ideal Retirement Balance")]
        public decimal IdealRetirementBalance { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Will you have Dependants at retirement?")]
        public string RetirementDependants { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Do you make Voluntary Contributions?")]
        public string VoluntaryContributions { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Frequency of voluntary contributions")]
        public string FrequencyOfVoluntaryContributions { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("How much voluntary contributions do you make per payment?")]
        public decimal PaymentPerVoluntaryContributions { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("What is the savings balanace in yoor pension pot right now?")]
        public decimal CurrentRetirementSavingBalance { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("Do you have a Will?")]
        public string Will { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("How much other annual income will you receive at retirement asides your RSA?")]
        public decimal IncomeAsideRsa { get; set; }
        [DisplayName("You won a TV game show, you are offered a choice of the following prices, which would you choose?")]
        [Required(ErrorMessage = "The field is required!")]
        public string TvShow { get; set; }
        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("In general, how would your best friend describe you?")]
        public string BestFriend { get; set; }
        [Required(ErrorMessage = "The field is required!")]
        [DisplayName("If you unexpectedly received N5,000,000 to invest, what would you do?")]
        public string Invest { get; set; }

        public decimal CurrentMonthlyAVC => 30000;
    }
}