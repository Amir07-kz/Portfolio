using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Misc.Services.EmailSender;
using Portfolio.Models;

namespace Portfolio.Controllers
{

    public class ContactsController : Controller
    {
        private IEmailService EmailSender;

        public ContactsController(IEmailService _emailSender)
        {
            EmailSender = _emailSender;
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacts([FromForm] User userData)
        {

            var message = new Message(new string[] { "testaccnum00001@gmail.com" }, "Users Data", $"Email:{userData.Email}\nName:{userData.Name}\nSubject:{userData.Subject}\nMessage:\n{userData.Message}");
            await EmailSender.SendEmailAsync(message);
            return Ok();
        }
    }

}