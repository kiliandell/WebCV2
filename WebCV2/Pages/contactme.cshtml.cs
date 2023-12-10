using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;

namespace WebCV2.Pages
{
    public class contactmeModel : PageModel
    {

        private readonly ILogger<contactmeModel> _logger;

        public contactmeModel(ILogger<contactmeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(string name, string email, string message)
        {
            using (SmtpClient smtpClient = new SmtpClient("//"))
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("kiliandel07@gmail.com", "Minecraftdu07");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("testKD@test.com"),
                    Subject = "Contact CV",
                    Body = $"Name: {name}\nEmail: {email}\n\nMessage:\n{message}",
                    IsBodyHtml = false
                };

                mailMessage.To.Add("kiliandel07@gmail.com");

                smtpClient.Send(mailMessage);
            }

            return RedirectToPage("/ContactConfirmation");
        }
    }
}
