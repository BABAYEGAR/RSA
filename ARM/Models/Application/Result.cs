using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARM.Models.Application
{
    public class Result
    {
        public decimal? ExpectedRetirementBalance { get; set; }
        public decimal IdealRetirementBalance { get; set; }
        public long RetirementVariance { get; set; }
        public decimal? AdjustedAnualAvc { get; set; }
        public decimal? AdjustedAnualAvcCloseShortfall { get; set; }
        public decimal ProjectedAnnualSalary { get; set; }
        public decimal MonthlyProgrammedWithdrawalPayment { get; set; }
        public decimal ExpectedLumsum { get; set; }
        public string FundType { get; set; }
        public string Will { get; set; }
        public string GeneralAdvice { get; set; }
        public string RiskAppetite { get; set; }
        public decimal OtherIncome { get; set; }
        public long Age { get; set; }
        public string RSA { get; set; }
    }
}
