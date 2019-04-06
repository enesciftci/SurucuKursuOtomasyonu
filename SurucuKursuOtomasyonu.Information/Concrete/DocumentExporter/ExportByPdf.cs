using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.Information.Concrete.DocumentExporter
{
    public class ExportByPdf : IExportByPdfService
    {
        public void CreateDebtPdf(string studentNumber, string studentNameSurname, string studentNationalNumber,
            string registrationDate, string studentDebt, string studentTotalDebt, string studentQuantityInstallment,
            string studentIbanNumber, string studentWantLicenceType)
        {
            try
            {
                #region kullanılan klasörleri oluştur

                if (!Directory.Exists(@"c:\SurucuKursu"))
                {
                    Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler");
                    Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\img");
                    Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\pdf");
                }

                #endregion

                #region Font seç

                var trArial = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\tahoma.ttf", BaseFont.IDENTITY_H,
                    BaseFont.NOT_EMBEDDED);
                var fontArial = new Font(trArial, 10, Font.NORMAL, BaseColor.DARK_GRAY);
                var fontArialHeader = new Font(trArial, 13, Font.BOLD, BaseColor.BLACK);
                var fontArialbold = new Font(trArial, 9, Font.BOLD, BaseColor.DARK_GRAY);
                var fontArialboldgeneral = new Font(trArial, 10, Font.BOLD, BaseColor.BLACK);

                #endregion

                #region Borç pdf oluştur

                var pdfFile = new Document();
                try
                {
                    PdfWriter.GetInstance(pdfFile,
                        new FileStream(
                            @"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\pdf\" + studentNameSurname +
                            ".pdf", FileMode.CreateNew));
                }
                catch (Exception)
                {
                    var dialog = MessageBox.Show(@"Aynı İsimli Dosya Mevcut Üzerine Yazılsın Mı ?", @"Uyarı",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        PdfWriter.GetInstance(pdfFile,
                            new FileStream(
                                @"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\pdf\" + studentNameSurname +
                                ".pdf", FileMode.Append));
                        MessageBox.Show(@"İşlem Başarılı", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                pdfFile.Open();

                #endregion

                #region Borç pdf oluşturan bilgileri

                pdfFile.AddCreator("Yönetici"); //Oluşturan kişinin isminin eklenmesi
                pdfFile.AddCreationDate(); //Oluşturulma tarihinin eklenmesi
                pdfFile.AddAuthor("Yönetici"); //Yazarın isiminin eklenmesi
                pdfFile.AddHeader("Başlık", "Sürücü Kursu Otomasyonu");
                pdfFile.AddTitle("Öğrenci Borç Bilgileri"); //Başlık ve title eklenmesi

                #endregion

                #region firma resmi ve tarihi oluştur

                var jpgimg =
                    Image.GetInstance(
                        @"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\img\logo.png");
                jpgimg.ScalePercent(35);
                jpgimg.Alignment = Image.LEFT_ALIGN;

                var pdfTableHeader = new PdfPTable(3)
                {
                    TotalWidth = 500f,
                    LockedWidth = true
                };
                pdfTableHeader.DefaultCell.Border = Rectangle.NO_BORDER;

                var cellheader1 = new PdfPCell(jpgimg)
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_BOTTOM,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader1);

                var cellheader2 = new PdfPCell(new Phrase("Öğrenci Borç Bilgileri", fontArialHeader))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader2);


                var cellheader3 = new PdfPCell(new Phrase(DateTime.Now.ToShortDateString(), fontArial))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader3);

                #endregion

                var p = new Phrase("\n");

                #region Tabloyu Oluştur

                var pdfTable = new PdfPTable(2)
                {
                    TotalWidth = 500f,
                    LockedWidth = true
                };
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.DefaultCell.BorderColor = BaseColor.GRAY;

                pdfTable.AddCell(new Phrase("Öğrenci Numarası", fontArial));
                pdfTable.AddCell(new Phrase(studentNumber, fontArial));

                pdfTable.AddCell(new Phrase("Öğrenci Adı Soyadı", fontArial));
                pdfTable.AddCell(new Phrase(studentNameSurname, fontArial));


                pdfTable.AddCell(new Phrase("Öğrenci Kimlik Numarası", fontArial));
                pdfTable.AddCell(new Phrase(studentNationalNumber, fontArial));

                pdfTable.AddCell(new Phrase("Öğrenci Kayıt Tarihi", fontArial));
                pdfTable.AddCell(new Phrase(registrationDate, fontArial));

                pdfTable.AddCell(new Phrase("Kayıt Ücreti", fontArial));
                pdfTable.AddCell(new Phrase(studentDebt, fontArial));

                pdfTable.AddCell(new Phrase("Kalan Borç", fontArial));
                pdfTable.AddCell(new Phrase(studentTotalDebt, fontArial));

                pdfTable.AddCell(new Phrase("Taksit Sayısı", fontArial));
                pdfTable.AddCell(new Phrase(studentQuantityInstallment, fontArial));

                pdfTable.AddCell(new Phrase("Öğrenci Iban Numarası", fontArial));
                pdfTable.AddCell(new Phrase(studentIbanNumber, fontArial));

                pdfTable.AddCell(new Phrase("İstenen Belge Tipi", fontArial));
                pdfTable.AddCell(new Phrase(studentWantLicenceType, fontArial));

                #endregion


                #region Pdfe yaz ve dosyayı kapat

                if (pdfFile.IsOpen() == false) pdfFile.Open();
                pdfFile.Add(pdfTableHeader);
                pdfFile.Add(p);
                pdfFile.Add(pdfTable);
                pdfFile.Close();

                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show(@"Birşeyler Ters Gitti Lütfen Tekrar Deneyin");
            }
        }
    }
}