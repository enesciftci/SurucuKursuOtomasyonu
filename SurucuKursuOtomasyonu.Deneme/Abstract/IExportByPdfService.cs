namespace SurucuKursuOtomasyonu.Information.Abstract
{
  public interface IExportByPdfService
  {
     void CreateDebtPdf(string studentNumber, string studentNameSurname, string studentNationalNumber,
          string registrationDate, string studentDebt, string studentTotalDebt, string studentQuantityInstallment,
          string studentIbanNumber, string studentWantLicenceType);
  }
}
