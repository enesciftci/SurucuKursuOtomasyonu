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
    public class LicenceTypeManager : ILicenceTypeService
    {
        private ILicenceTypeDal _licenceTypeDal;

        public LicenceTypeManager(ILicenceTypeDal licenceTypeDal)
        {
            _licenceTypeDal = licenceTypeDal;
        }

        public List<LicenceType> GetLicenceTypes()
        {

            return _licenceTypeDal.GetAll();
        }

    }
}
