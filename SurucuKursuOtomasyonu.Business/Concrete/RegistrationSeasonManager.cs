using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Concrete
{
   public class RegistrationSeasonManager:IRegistrationSeasonService
    {
        private IRegistrationSeasonDal _registrationSeasonDal;

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
