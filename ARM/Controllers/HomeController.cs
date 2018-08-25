﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ARM.Models;
using ARM.Models.Authentication;
using ARM.Models.Services;
using Microsoft.AspNetCore.Hosting;

namespace ARM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnv;

        public HomeController(IHostingEnvironment env)
        {
            _hostingEnv = env;
        }
        public IActionResult Index()
        {

            return View();
        }
        [Route("Retirement_Calculator/Profiling")]
        public IActionResult Profiler()
        {
            return View();
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
