using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AboutContact(ContactFormViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("recipient@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("sender@outlook.com");  // replace with valid value
                message.Subject = viewModel.Subject;
                message.Body = string.Format(body, viewModel.Name, viewModel.Email, viewModel.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "user@outlook.com",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("AboutContactSent");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(viewModel);
        }

        public IActionResult AboutContactSent()
        {
            return View();
        }

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
