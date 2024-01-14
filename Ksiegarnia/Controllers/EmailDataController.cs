using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration; // Dodaj to

namespace Ksiegarnia.Controllers
{
    public class EmailDataController : Controller
    {
        private readonly IConfiguration _configuration;

        public EmailDataController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Kontakt";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                await SendEmail(model);
                ViewBag.Message = "Wiadomość została wysłana";
                return View();
            }
            return View(model);
        }

        private async Task SendEmail(ContactModel model)
        {
            var emailSettings = _configuration.GetSection("EmailSettings");
            var smtpServer = emailSettings["SmtpServer"];
            var smtpPort = int.Parse(emailSettings["SmtpPort"]);
            var email = emailSettings["EmailAddress"];
            var password = emailSettings["EmailPassword"];

            var message = new MailMessage();
            message.To.Add("ksiegarnia.im@gmail.com");
            message.From = new MailAddress(model.Email);
            message.Subject = model.Subject;
            message.Body = $"Od: {model.FullName}\nEmail: {model.Email}\n\n{model.Message}";

            using (var smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(email, password);
                smtpClient.EnableSsl = true;
                await smtpClient.SendMailAsync(message);
            }
        }
    }
}
