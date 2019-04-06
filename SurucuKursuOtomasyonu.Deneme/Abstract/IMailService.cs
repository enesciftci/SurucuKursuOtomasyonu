using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurucuKursuOtomasyonu.Information.Abstract
{
   public interface IMailService
   {
       void SendMail(string mail,string mailContent);
   }
}
