using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Abstract
{
   public interface IRegistrationSeasonService
   {
       List<RegistrationSeason> GetSeasons();
   }
}
