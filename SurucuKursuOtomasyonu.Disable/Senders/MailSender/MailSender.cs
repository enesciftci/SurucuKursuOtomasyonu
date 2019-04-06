using System.Net;
using System.Net.Mail;

namespace SurucuKursuOtomasyonu.Information.Senders.MailSender
{
    public static class MailSender
    {
        private static readonly SmtpClient _smtpClient = new SmtpClient();
        private static readonly MailMessage mailMessage = new MailMessage();

        public static void SendMail(string mail, string mailContent)
        {
            // _smtpClient.Port = 587;
            /*  _smtpClient.Host = "smtp.gmail.com";
              _smtpClient.UseDefaultCredentials = false;
            //  _smtpClient.EnableSsl = true;
              _smtpClient.Credentials=new NetworkCredential("ciftcienes23@gmail.com","anadolu11Aa.");
             */
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