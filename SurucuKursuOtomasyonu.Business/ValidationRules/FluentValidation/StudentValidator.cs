using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.Business.Utilities;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(p => p.StudentId).NotEmpty().When(p => false);

            RuleFor(p => p.StudentName).NotEmpty().WithMessage("Ad Boş Olamaz");

            RuleFor(p => p.StudentSurname).NotEmpty().WithMessage("Soyad Boş Olamaz");

            RuleFor(p => p.StudentNationalNumber).NotEmpty().Must(SubValidator.ValidateNationalNumber)
                .WithMessage("Kimlik Numarası Geçersiz");

            RuleFor(p => p.StudentGender).NotEmpty().WithMessage("Cinsiyet Boş Olamaz");

            RuleFor(p => p.StudentEmail).NotEmpty().Must(SubValidator.EmailValidator).WithMessage("EMaili Doğru Giriniz");

            RuleFor(p => p.StudentBirthdate).NotEmpty().LessThanOrEqualTo(DateTime.Today.AddYears(-16))
                .WithMessage("16 Yaşından Küçük Öğrenci Kaydı Yapılamaz.");

            RuleFor(p => p.RegistrationDate).NotEmpty().WithMessage("Kayıt Tarihi Boş Olamaz");

            RuleFor(p => p.RegistrationSeason).NotEmpty().WithMessage("Kayıt Sezonu Boş Olamaz");

            RuleFor(p => p.StudentDebt).NotEmpty().GreaterThanOrEqualTo(100)
                .WithMessage("Kayıt Ücreti 100 TL'den Az Olamaz");

            RuleFor(p => p.StudentTotalDebt).NotEmpty().GreaterThanOrEqualTo(100);

            RuleFor(p => p.QuantityInstallment).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(6)
                .WithMessage("Taksit Sayısı 1-6 Arasında Olmalı");

            RuleFor(p => p.StudentPlaceofBirth).GreaterThan(0).WithMessage("Doğum Yeri Boş Olamaz");

            RuleFor(p => p.StudentPhoneNumber).NotEmpty().Must(SubValidator.ValidateFormatPhoneNumber)
                .WithMessage("Geçersiz Telefon Numarası örn:05xxxxxxxxx Formatında Omalı");

            RuleFor(p => p.StudentAdress).NotEmpty().WithMessage("Adres Alanı Boş Olamaz");

            RuleFor(p => p.StudentIbanNumber).NotEmpty().Must(SubValidator.IbanValidator)
                .WithMessage("IBAN Numarası Geçersiz örn:TR560006200000012990022604 Formatında Olmalı");

            RuleFor(p => p.StudentWantLicenceType).NotEmpty().WithMessage("Lisans Türü Boş Olamaz");

 

        }

    }
}