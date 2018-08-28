using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ARM.Models;
using ARM.Models.Application;
using ARM.Models.Authentication;
using ARM.Models.DataBaseConnections;
using ARM.Models.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ARM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ARMDataContext _databaseConnection;
        private readonly IHostingEnvironment _hostingEnv;

        /// <summary>
        ///     Intitialize some connections from the class constructor
        /// </summary>
        /// <param name="databaseConnection"></param>
        public HomeController(IHostingEnvironment env, ARMDataContext databaseConnection)
        {
            _databaseConnection = databaseConnection;
            _hostingEnv = env;
        }

        public IActionResult Index()
        {
            HttpContext.Session.Remove("customerData");
            HttpContext.Session.Remove("Profiling");
            HttpContext.Session.Remove("result");
            HttpContext.Session.Clear();
            return View();
        }

        public IActionResult BasicInfo()
        {
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                return View(data);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BasicInfo(Profiling profiling)
        {
            try
            {
                HttpContext.Session.SetString("Profiling", JsonConvert.SerializeObject(profiling));
                if (HttpContext.Session.GetString("result") != null)
                {
                    var result = new Result();
                    if (HttpContext.Session.GetString("Profiling") != null)
                    {
                        var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                        result.IdealRetirementBalance = data.IdealRetirementBalance;
                        result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                            DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                            data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                        result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                            DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.CurrentRetirementSavingBalance,
                            data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC, data.IncomeAsideRsa, data.IdealRetirementBalance);
                        result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                        result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                            DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                            data.MonthlyEmployerContribution);
                        result.Will = data.Will;
                        result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                        result.Age = data.RetirementAge;
                        result.RSA = data.RsaAccount;
                    }
                    return View("Result", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         
            return View("PensionPot",profiling);
        }

  
        public IActionResult PensionPot()
        {
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                return View(data);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PensionPot(Profiling profiling)
        {
            HttpContext.Session.SetString("Profiling", JsonConvert.SerializeObject(profiling));
            if (HttpContext.Session.GetString("result") != null)
            {
                var result = new Result();
                if (HttpContext.Session.GetString("Profiling") != null)
                {
                    var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                    result.IdealRetirementBalance = data.IdealRetirementBalance;
                    result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                    result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.CurrentRetirementSavingBalance,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC, data.IncomeAsideRsa, data.IdealRetirementBalance);
                    result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                    result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                        data.MonthlyEmployerContribution);
                    result.Will = data.Will;
                    result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                    result.Age = data.RetirementAge;
                    result.RSA = data.RsaAccount;
                }
                return View("Result", result);
            }
            return View("IdealRetirement",profiling);
        }

        public IActionResult IdealRetirement()
        {
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                return View(data);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IdealRetirement(Profiling profiling)
        {
            HttpContext.Session.SetString("Profiling", JsonConvert.SerializeObject(profiling));
            if (HttpContext.Session.GetString("result") != null)
            {
                var result = new Result();
                if (HttpContext.Session.GetString("Profiling") != null)
                {
                    var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                    result.IdealRetirementBalance = data.IdealRetirementBalance;
                    result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                    result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.CurrentRetirementSavingBalance,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC, data.IncomeAsideRsa, data.IdealRetirementBalance);
                    result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                    result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                        data.MonthlyEmployerContribution);
                    result.Will = data.Will;
                    result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                    result.Age = data.RetirementAge;
                    result.RSA = data.RsaAccount;
                }
                return View("Result", result);
            }
            return View("RiskAppetite", profiling);
        }
        public IActionResult RiskAppetite()
        {
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var datas = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                return View(datas);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RiskAppetite(Profiling profiling)
        {
            HttpContext.Session.SetString("Profiling", JsonConvert.SerializeObject(profiling));
            if (HttpContext.Session.GetString("result") != null)
            {
                var result = new Result();
                if (HttpContext.Session.GetString("Profiling") != null)
                {
                    var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                    result.IdealRetirementBalance = data.IdealRetirementBalance;
                    result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                    result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.CurrentRetirementSavingBalance,
                        data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC, data.IncomeAsideRsa, data.IdealRetirementBalance);
                    result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                    result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                        DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                        data.MonthlyEmployerContribution);
                    result.Will = data.Will;
                    result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                    result.Age = data.RetirementAge;
                    result.RSA = data.RsaAccount;
                }
                return View("Result", result);
            }
            return View("SignUp");
        }
        public IActionResult SignUp()
        {
            if (HttpContext.Session.GetString("customerData") != null)
            {
                var data = JsonConvert.DeserializeObject<CustomerData>(HttpContext.Session.GetString("customerData"));
                return View(data);
            }

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(CustomerData customerData)
        {
            HttpContext.Session.SetString("customerData", JsonConvert.SerializeObject(customerData));
            var result = new Result();
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                result.IdealRetirementBalance = data.IdealRetirementBalance;
                result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                    data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.CurrentRetirementSavingBalance,
                    data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC, data.IncomeAsideRsa, data.IdealRetirementBalance);
                result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                    data.MonthlyEmployerContribution);
                result.Will = data.Will;
                result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                result.Age = data.RetirementAge;
                result.RSA = data.RsaAccount;
            }
            HttpContext.Session.SetString("result", JsonConvert.SerializeObject(result));
            return View("Result", result);
        }
        public IActionResult Result()
        {
            var result = new Result();
            if (HttpContext.Session.GetString("Profiling") != null)
            {
                var data = JsonConvert.DeserializeObject<Profiling>(HttpContext.Session.GetString("Profiling"));
                result.IdealRetirementBalance = data.IdealRetirementBalance;
                result.ExpectedRetirementBalance = new Calculator().ExpectedRsaBalanceForRetirement(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.IncomeAsideRsa,
                    data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC);
                result.AdjustedAnualAvc = new Calculator().AdjustedAnnualAvc(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge,data.CurrentRetirementSavingBalance,
                    data.MonthlyEmployeeContribution + data.MonthlyEmployerContribution + data.CurrentMonthlyAVC,data.IncomeAsideRsa,data.IdealRetirementBalance);
                result.AdjustedAnualAvcCloseShortfall = result.AdjustedAnualAvc + data.CurrentMonthlyAVC;
                result.ProjectedAnnualSalary = new Calculator().AnuualSalaryProjections(
                    DateTime.Now.Year - data.DateOfBirth.Year, data.RetirementAge, data.MonthlyEmployeeContribution,
                    data.MonthlyEmployerContribution);
                result.Will = data.Will;
                result.RiskAppetite = new Calculator().FundSelector(data.TvShow, data.BestFriend, data.Invest);
                result.Age = data.RetirementAge;
                result.RSA = data.RsaAccount;
                HttpContext.Session.SetString("result", JsonConvert.SerializeObject(result));
                return View(result);
            }
      
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitRating(IFormCollection collection)
        {
            var rating = Convert.ToInt64(collection["ratings[]"]);
            if (HttpContext.Session.GetString("customerData") != null)
            {
                var data = JsonConvert.DeserializeObject<CustomerData>(HttpContext.Session.GetString("customerData"));
                data.Rating = rating;
                data.DateCreated = DateTime.Now;
                data.DateLastModified = DateTime.Now;
                _databaseConnection.Add(data);
                _databaseConnection.SaveChanges();
            }
            HttpContext.Session.Remove("customerData");
            HttpContext.Session.Remove("Profiling");
            HttpContext.Session.Remove("result");
            return View("Success");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
