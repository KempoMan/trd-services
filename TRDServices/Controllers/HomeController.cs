using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRDServices.Models;

namespace TRDServices.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ServicesAdministrative()
        {
            return View();
        }

        public IActionResult ServicesRecruitment()
        {
            return View();
        }

        public IActionResult ServicesTaxPrep()
        {
            return View();
        }

        public IActionResult Contracts()
        {
            return View();
        }

        public IActionResult AboutContact()
        {
            return View(new ContactFormViewModel());
        }


        //[HttpPost]
        //public IActionResult AboutContact(ContactFormViewModel viewModel, string returnUrl = null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // work with the viewModel
        //    }
        //    // If we got this far, something failed, redisplay form
        //    return View(viewModel);
        //}


        public IActionResult AboutTerms()
        {
            return View();
        }

        public IActionResult AboutPrivacy()
        {
            return View();
        }
    }
}
