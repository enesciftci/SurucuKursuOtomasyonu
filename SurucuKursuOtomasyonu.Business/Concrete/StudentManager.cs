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

        public List<Student> GetBySeason(int registrationSeason)
        {
            return _studentDal.GetAll(p => p.RegistrationSeason == registrationSeason);
        }

        public List<Student> GetByNationalNumber(string nationalNumber)
        {
            return _studentDal.GetAll(p=>p.StudentNationalNumber==nationalNumber);

        }

        public List<Student> GetByName(string name)
        {
            return _studentDal.GetAll(p => p.StudentName == name);
        }

        public Student Get(string nationalNumber)
        {
            return _studentDal.Get(p => p.StudentNationalNumber==nationalNumber);
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
          
                _studentDal.Delete(student);
           
        }
    }
}
