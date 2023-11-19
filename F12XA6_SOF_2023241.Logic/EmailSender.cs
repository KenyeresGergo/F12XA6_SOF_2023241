using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace F12XA6_SOF_2023241.Logic
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (SmtpClient client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("keny.gergo@stud.uni-obuda.hu", "K1kelet?"),
                TargetName = "STARTTLS/smtp.office365.com",
                EnableSsl = true

            })
            {
                MailMessage message = new MailMessage()
                {
                    From = new MailAddress("keny.gergo@stud.uni-obuda.hu"),
                    Subject = subject,
                    IsBodyHtml = true,
                    Body = htmlMessage,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                };
                message.To.Add(email);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {

                }
            }
            return Task.CompletedTask;
        }
    }
}

