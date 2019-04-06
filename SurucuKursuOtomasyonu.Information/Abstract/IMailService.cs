namespace SurucuKursuOtomasyonu.Information.Abstract
{
    public interface IMailService
    {
        void SendMail(string mail, string mailContent);
    }
}