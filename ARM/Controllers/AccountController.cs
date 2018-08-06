using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARM.Models;
using ARM.Models.Authentication;
using ARM.Models.Enum;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ARM.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHostingEnvironment _hostingEnv;

        public AccountController(IHostingEnvironment env)
        {
            _hostingEnv = env;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserAuthentication userAuthentication)
        {
            var response = new AuthenticationFactory().LoginUser(userAuthentication, _hostingEnv.WebRootPath + $@"\Xml\UserAuthentication.xml");
            if (response.responsecode == "1")
            {
                TempData["display"] = response.responsemessage;
                TempData["notificationtype"] = NotificationType.Success.ToString();
            }
            TempData["display"] = response.responsemessage;
            TempData["notificationtype"] = NotificationType.Error.ToString();
            return View(userAuthentication);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterUser registerUser)
        {
            var response = new AuthenticationFactory().RegisterUser(registerUser, _hostingEnv.WebRootPath + $@"\Xml\RegisterUser.xml");
            TempData["display"] = response.responsemessage;
            TempData["notificationtype"] = NotificationType.Success.ToString();
            if (response.responsecode == "1")
            {
                TempData["display"] = response.responsemessage;
                TempData["notificationtype"] = NotificationType.Success.ToString();
            }
            TempData["display"] = response.responsemessage;
            TempData["notificationtype"] = NotificationType.Error.ToString();
            return View(registerUser);
        }
    }
}