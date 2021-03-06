﻿using System.Collections.Generic;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();

        List<Student> GetBySeason(int registrationSeason);

        List<Student> GetByNationalNumber(string nationalNumber);

        List<Student> GetByName(string name);
        List<Student> GetDebtor();
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}