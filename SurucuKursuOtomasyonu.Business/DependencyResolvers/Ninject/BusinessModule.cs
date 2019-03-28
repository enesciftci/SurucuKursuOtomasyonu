using Ninject.Modules;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;

namespace SurucuKursuOtomasyonu.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<IRegistrationSeasonService>().To<RegistrationSeasonManager>().InSingletonScope();
            Bind<IRegistrationSeasonDal>().To<EfRegistrationSeasonDal>().InSingletonScope();
            Bind<ILicenceTypeService>().To<LicenceTypeManager>().InSingletonScope();
            Bind<ILicenceTypeDal>().To<EfLicenceTypeDal>().InSingletonScope();
            Bind<ICityService>().To<CityManager>().InSingletonScope();
            Bind<ICityDal>().To<EfCityDal>().InSingletonScope();


        }
    }
}
