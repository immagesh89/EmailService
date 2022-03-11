using EmailService.Model;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.Service
{
    public class EmailService : IEmailService
    {
        public void SendEmail(EmailModel emailmodel)
        {
            var apiKey = Environment.GetEnvironmentVariable("SendGrid");
            var client = new SendGridClient("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");
            var from = new EmailAddress("brainvalley89@gmail.com");
            var subject = emailmodel.Subject;
            var to = new EmailAddress(emailmodel.ToEmail);
            var plainTextContent = emailmodel.Body;
            var htmlContent = "<strong>My Test Mail</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg).Result;
        }
    }
}
