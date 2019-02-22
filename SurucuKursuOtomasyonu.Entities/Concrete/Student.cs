using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Abstract;

namespace SurucuKursuOtomasyonu.Entities.Concrete
{
   public class Student:IEntity
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentNationalNumber { get; set; }
        public string StudentEmail { get; set; }
        public DateTime StudentBirthdate { get; set; }
        public DateTime RegistrationTime { get; set; }//öğrenci kayıt tarihi
        public int RegistrationSeason { get; set; }//kayıtlı bulunduğu sezon bu alana göre bulunacak
        public double StudentDebt { get; set; }//Öğrencinin borcu
        public int QuantityInstallment { get; set; }//Taksit miktarı 
        /*Her ayın öğrencinin kayıt olduğu günde borç miktarı taksit sayısına bölünüp
         mail olarak öğrenciye gönderilecek öğrenci borcu ödediğinde ödenen miktar borç toplamından
         düşülecek */
        public string StudentPlaceofBirth { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string StudentAdress { get; set; }
        public string StudentIbanNumber { get; set; }
        
    }
}
