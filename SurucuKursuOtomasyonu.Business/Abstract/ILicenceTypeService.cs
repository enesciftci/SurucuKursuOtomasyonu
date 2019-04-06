using System.Collections.Generic;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Abstract
{
    public interface ILicenceTypeService
    {
        List<LicenceType> GetLicenceTypes();
    }
}