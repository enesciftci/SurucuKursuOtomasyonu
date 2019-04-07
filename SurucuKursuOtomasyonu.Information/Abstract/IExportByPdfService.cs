using iTextSharp.text.pdf;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System.Collections.Generic;
using iTextSharp.text;

namespace SurucuKursuOtomasyonu.Information.Abstract
{
    public interface IExportByPdfService
    {
        void CreateDebtPdf(Student student);

        void CreateDebtPdf(string studentNumber,string nameSurname,string studentNationalNumber, string registrationDate, string studentDebt,string remainingDebt,string remainingInstallment, string ibanNumber,
            string studentWantLicenceType);
        void CreateRecordPdf(Student student);

    }
}