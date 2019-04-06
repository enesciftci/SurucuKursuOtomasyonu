using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace InformationService
{
    internal class DebtorStudents : Student
    {
        public string NameSurname { get; set; }
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Debt { get; set; }
    }

    public class InnerOperation : StudentManager
    {
        public InnerOperation(IStudentDal studentDal) : base(studentDal)
        {
            var debtorStudent = new DebtorStudents();
            var debtorStudents = new List<Student>();
            foreach (var student in studentDal.GetAll(p => p.StudentDebt > 0))
            {
                debtorStudent.NameSurname = student.StudentName + " " + student.StudentSurname;
                debtorStudent.MailAdress = student.StudentEmail;
                debtorStudent.PhoneNumber = student.StudentPhoneNumber;
                var mainDebt = student.StudentDebt; //databasedeki ana borç
                var totalDebt = student.StudentTotalDebt; // databasedeki kalan borç
                var quantityInstallment = student.QuantityInstallment;
                var quantityPerInstallment = mainDebt / quantityInstallment;
                debtorStudent.Debt = totalDebt - quantityPerInstallment;
                if (debtorStudent.Debt > 0)
                {
                    debtorStudents.Add(debtorStudent);
                    var json = JsonConvert.SerializeObject(debtorStudents);
                    Console.WriteLine(json);
                }
            }
        }
    }
}