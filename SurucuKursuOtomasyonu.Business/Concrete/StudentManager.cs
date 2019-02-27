using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public List<Student> GetAll()
        {

            return _studentDal.GetAll();
        }

       public List<Student> GetBySeason()
       {
           return _studentDal.GetAll(p => p.RegistrationSeason ==1);
       }

        public Student Get(int id)
        {
            return _studentDal.Get(p => p.RegistrationSeason == id);
        }
    }
}
