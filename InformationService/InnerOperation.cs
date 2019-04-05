using System;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;

namespace InformationService
{
    class DebtorStudents:Student
    {
        public string NameSurname { get; set; }
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Debt { get; set; }
    }
    public class InnerOperation:StudentManager
    {
        public InnerOperation(IStudentDal studentDal) :base(studentDal)
        {
           DebtorStudents debtorStudent=new DebtorStudents();
            List <Student>debtorStudents=new List<Student>();
            foreach (var student in studentDal.GetAll(p=>p.StudentDebt>0))
            {
              debtorStudent.NameSurname = student.StudentName + " " + student.StudentSurname;
               debtorStudent.MailAdress = student.StudentEmail;
             debtorStudent.PhoneNumber= student.StudentPhoneNumber;
               decimal mainDebt= student.StudentDebt;//databasedeki ana borç
                decimal totalDebt = student.StudentTotalDebt;// databasedeki kalan borç
                int quantityInstallment = student.QuantityInstallment;
                decimal quantityPerInstallment = mainDebt / quantityInstallment;
                debtorStudent.Debt = totalDebt - quantityPerInstallment;
                 if (debtorStudent.Debt >0)
                {
                 debtorStudents.Add(debtorStudent);
                    string json = JsonConvert.SerializeObject(debtorStudents);
                    Console.WriteLine(json);
                }
                
            }
        }
    }
}
