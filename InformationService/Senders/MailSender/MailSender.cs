using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using  System.Net.Mail;

namespace SurucuKursu.InformationService.Senders.MailSender
{
   public static class MailSender
    {
         static SmtpClient _smtpClient = new SmtpClient();
       static MailMessage mailMessage = new MailMessage();
        public static void SendMail(string mail,string mailContent)
        {
         
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            _smtpClient.EnableSsl = true;
            _smtpClient.Host = "smtp.gmail.com";
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential("ciftcienes23@gmail.com","password.");

            mailMessage.From = new MailAddress("ciftcienes23@gmail.com");
            mailMessage.Subject = "Sürücü Kursu Otomasyonu";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = mailContent;
            mailMessage.To.Add(mail);
         
            
           
            _smtpClient.Send(mailMessage);

        }

       
    }
}
