using FileUploadDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadDemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}