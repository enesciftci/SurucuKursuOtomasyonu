﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework
{
  public class EfStudentDal:EfEntityRepositoryBase<Student,SurucuKursuContext>,IStudentDal
    {

       
     
    }
}
