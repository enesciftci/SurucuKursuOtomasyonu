using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.DataAccess.Abstract
{
   public interface IStudentDal:IEntityRepository<Student>
   {
      
   }
}
