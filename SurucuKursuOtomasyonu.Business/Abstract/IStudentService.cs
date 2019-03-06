using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Abstract
{
   public interface IStudentService
    {
        List<Student> GetAll();

        List<Student> GetBySeason();
            //   List<Student> GetBySeason();
        Student Get(int id);
        void Add(Student student);
    }
}
