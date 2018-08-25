using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARM.Models.Application;
using ARM.Models.Enum;

namespace ARM.Models.Services
{
    public class Calculator
    {
        public string FundSelector(string question1, string question2, string question3)
        {
            string recommendedFund = null;
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.Low.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.Low.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }
            if (question1 == RiskEnum.Modereate.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundTwo.ToString();
            }
            if (question1 == RiskEnum.Low.ToString() && question2 == RiskEnum.Modereate.ToString() &&
                question3 == RiskEnum.Modereate.ToString())
            {
                recommendedFund = FundType.FundThree.ToString();
            }
            if (question1 == RiskEnum.High.ToString() && question2 == RiskEnum.High.ToString() &&
                question3 == RiskEnum.High.ToString())
            {
                recommendedFund = FundType.FundOne.ToString();
            }

            return recommendedFund;
        }

        public List<Contribution> MonthLyContributions(long currentAge, long retirementAge, decimal monthlyContribution)
        {
            long monthCount = 0;
            long ageRange = (retirementAge - currentAge + 1) * 12;
            List<Contribution> contributions = new List<Contribution>();
            decimal rsaBalance = 0;
            for (int i = 0; i < ageRange; i++)
            {
                monthCount = monthCount + 1;
                if (i == 0)
                {
                    rsaBalance = monthlyContribution + rsaBalance + (decimal)(0.66667 * (double)(monthlyContribution + rsaBalance) / 100);

                }

                if (i > 0)
                {
                    rsaBalance = contributions[i - 1].RsaBalance + monthlyContribution + (decimal)(0.66667 * (double)(monthlyContribution + contributions[i - 1].RsaBalance) / 100);

                }
                var contribution = new Contribution
                {
                    Age = currentAge,
                    Month = monthCount,
                    Contributions = Math.Round(monthlyContribution,2),
                    RsaBalance = Math.Round(rsaBalance, 2)
                };
                contributions.Add(contribution);
                if (monthCount == 12)
                {
                    monthCount = 0;
                    monthlyContribution = Math.Round(monthlyContribution, 2) +  (4 * Math.Round(monthlyContribution, 2)) / 100;
                    currentAge = currentAge + 1;
                }
            }

            return contributions;
        }

        public decimal TransferredBalanaceForRetirement(long currentAge, long retirementAge, decimal rsaInitialBalance)
        {
            decimal balance = 0;
            decimal balancePercentage =  8;
            decimal balacePercentageCharge = balancePercentage / 100;
            decimal balancePercentageTotalCharge = balacePercentageCharge + 1;
            balance = Math.Round(rsaInitialBalance * (decimal) Math.Pow((double) balancePercentageTotalCharge,retirementAge-currentAge),2);
            return balance;
        }

        public decimal? ExpectedRsaBalanceForRetirement(long currentAge, long retirementAge, decimal rsaInitialBalance,
            decimal monthlyContribution)
        {
            decimal? transferredBalance = TransferredBalanaceForRetirement(currentAge, retirementAge, rsaInitialBalance);
            decimal? lastContribution =
                MonthLyContributions(currentAge, retirementAge, monthlyContribution).LastOrDefault()?.RsaBalance;
            var balance = transferredBalance + lastContribution;
            return balance;
        }

        public decimal MonthlyTotalEmolumentAssumption(decimal employeeContribution, decimal employerContribution)
        {
            decimal balance = employeeContribution + employeeContribution;
            balance = balance / (decimal) 0.18;
            return balance;
        }
        public decimal AnuualSalaryProjections(long currentAge, long retirementAge, decimal employeeContribution,decimal employerContribution)
        {
            decimal balance = 0;
            decimal balancePercentage = 4;
            decimal balacePercentageCharge = balancePercentage / 100;
            decimal balacePercentageTotalCharge = balacePercentageCharge + 1;
            decimal emolumentAssumption = MonthlyTotalEmolumentAssumption(employeeContribution, employerContribution);
            balance = Math.Round(emolumentAssumption * 12 * (decimal) Math.Pow((double) balacePercentageTotalCharge, retirementAge - currentAge),2);
            return balance;
        }
    }
}
