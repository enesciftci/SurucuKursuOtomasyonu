using System.Net;
using System.Net.Mail;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.Information.Concrete.Senders.MailSender
{
    public class MailSender : IMailService
    {
        private static readonly SmtpClient _smtpClient = new SmtpClient();
        private static readonly MailMessage mailMessage = new MailMessage();

        public void SendMail(string mail, string mailContent)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            _smtpClient.EnableSsl = true;
            _smtpClient.Host = "smtp.gmail.com";
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential("ciftcienes23@gmail.com", "anadolu11Aa.");

            mailMessage.From = new MailAddress("ciftcienes23@gmail.com");
            mailMessage.Subject = "Sürücü Kursu Otomasyonu";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = mailContent;
            mailMessage.To.Add(mail);


            _smtpClient.Send(mailMessage);
        }
    }
}