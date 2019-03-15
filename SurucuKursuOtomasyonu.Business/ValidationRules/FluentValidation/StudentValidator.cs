using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.Business.ValidationRules.FluentValidation
{
   public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(p => p.StudentID).NotEmpty();
            RuleFor(p => p.StudentName).NotEmpty();
            RuleFor(p => p.StudentSurname).NotEmpty();
            RuleFor(p => p.StudentNationalNumber).NotEmpty();
            RuleFor(p => p.StudentGender).NotEmpty();
            RuleFor(p => p.StudentEmail).NotEmpty();
            RuleFor(p => p.StudentBirthdate).NotEmpty();
            RuleFor(p => p.RegistrationDate).NotEmpty();
            RuleFor(p => p.RegistrationSeason).NotEmpty();
            RuleFor(p => p.StudentDebt).NotEmpty();
            RuleFor(p => p.StudentTotalDebt).NotEmpty();
            RuleFor(p => p.QuantityInstallment).NotEmpty();
            RuleFor(p => p.StudentPlaceofBirth).NotEmpty();
            RuleFor(p => p.StudentPhoneNumber).NotEmpty();
            RuleFor(p => p.StudentAdress).NotEmpty();
            RuleFor(p => p.StudentIbanNumber).NotEmpty();
            RuleFor(p => p.StudentWantLicenceType).NotEmpty();

            RuleFor(p => p.StudentDebt).GreaterThan(0);
            RuleFor(p => p.StudentTotalDebt).GreaterThan(0);
            RuleFor(p => p.QuantityInstallment).GreaterThan(0);
            RuleFor(p => p.StudentTotalDebt).GreaterThan(0);

            RuleFor(p => p.StudentBirthdate).LessThanOrEqualTo(DateTime.Today.AddYears(-18)).WithMessage("18 yaşından küçük öğrenci kaydı yapılamaz.");
            RuleFor(p => p.RegistrationDate).Equals(DateTime.Today);
        }

        
    }
}
