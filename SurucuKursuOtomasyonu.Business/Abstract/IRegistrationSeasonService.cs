using System.Collections.Generic;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Abstract
{
    public interface IRegistrationSeasonService
    {
        List<RegistrationSeason> GetSeasons();
    }
}