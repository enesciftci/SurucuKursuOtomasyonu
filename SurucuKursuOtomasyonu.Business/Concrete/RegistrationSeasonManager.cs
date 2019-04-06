using System.Collections.Generic;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Concrete
{
    public class RegistrationSeasonManager : IRegistrationSeasonService
    {
        private readonly IRegistrationSeasonDal _registrationSeasonDal;

        public RegistrationSeasonManager(IRegistrationSeasonDal registrationSeasonDal)
        {
            _registrationSeasonDal = registrationSeasonDal;
        }

        public List<RegistrationSeason> GetSeasons()
        {
            return _registrationSeasonDal.GetAll();
        }
    }
}