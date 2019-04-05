using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System.Collections.Generic;
using SurucuKursuOtomasyonu.Business.Utilities;
using SurucuKursuOtomasyonu.Business.ValidationRules.FluentValidation;

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

       
        public void Add(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
          
                _studentDal.Delete(student);
           
        }

        public List<Student> GetDebtor()
        {
            return _studentDal.GetAll(p=>p.StudentTotalDebt>0);
        }
    }
}
