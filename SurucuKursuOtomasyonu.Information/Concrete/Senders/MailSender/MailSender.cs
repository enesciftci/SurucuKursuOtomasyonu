using System.Net;
using System.Net.Mail;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.Information.Concrete.Senders.MailSender
{
    public class MailSender : IMailService
    {
        private static readonly SmtpClient SmtpClient = new SmtpClient();
        private static readonly MailMessage MailMessage = new MailMessage();

        public void SendMail(string mail, string mailContent)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            SmtpClient.EnableSsl = true;
            SmtpClient.Host = "smtp.gmail.com";
            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.Credentials = new NetworkCredential("ciftcienes23@gmail.com", "anadolu11Aa.");

            MailMessage.From = new MailAddress("ciftcienes23@gmail.com");
            MailMessage.Subject = "Sürücü Kursu Otomasyonu";
            MailMessage.IsBodyHtml = true;
            MailMessage.Body = mailContent;
            MailMessage.To.Add(mail);


            SmtpClient.Send(MailMessage);
        }
    }
}