using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework
{
    public class EfLicenceTypeDal : EfEntityRepositoryBase<LicenceType, SurucuKursuContext>, ILicenceTypeDal
    {
    }
}