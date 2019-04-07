using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.DataAccess.Abstract;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;
using SurucuKursuOtomasyonu.Entities.Abstract;
using SurucuKursuOtomasyonu.Entities.Concrete;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.Information.Concrete.DocumentExporter
{
    public class ExportByPdf : IExportByPdfService
    {
        private static Student _student = InstanceFactory.GetInstance<Student>();
      
       
        public void CreateDebtPdf(Student student)
        {
          CreateForDebtPdf(student);
        }
        public void CreateRecordPdf(Student student)
        {
         CreateForRecordPdf(student);
        }
        public void CreateDebtPdf(string studentNumber, string nameSurname, string studentNationalNumber, string registrationDate, string studentDebt, string remainingDebt, string remainingInstallment, string ibanNumber, string studentWantLicenceType)
        {
          
        }
        private static void CreateForRecordPdf(Student student)//for record pdf
        {
            ChooseDirectory();
            var fontArial = ChooseFont(out var fontArialHeader, out var fontArialbold, out var fontArialboldgeneral);
            var pdfFile = CreatePdf(student.StudentName+" "+student.StudentSurname);
            pdfFile.Open();
            Author(pdfFile);
            var pdfTableHeader = CreateLogoAndDate(fontArialHeader, fontArial);
            var p = new Phrase("\n");
            var pdfTable = CreateTable(student, fontArial);
            AddCell("Cinsiyet",student.StudentGender,fontArial,pdfTable);
            AddCell("Öğrenci Email",student.StudentEmail,fontArial,pdfTable);
           AddCell("Telefon Numarası",student.StudentPhoneNumber,fontArial,pdfTable);
           
            WritePdfAndCloseFile(pdfFile, pdfTableHeader, p, pdfTable);
        }
        private static void CreateForDebtPdf(Student student)//for debt pdf
        {
            try
            {
              // kullanılan klasörleri oluştur
                ChooseDirectory();
            // Font seç
               var fontArial = ChooseFont(out var fontArialHeader, out var fontArialbold, out var fontArialboldgeneral);
           
              // pdf oluştur
                var pdfFile = CreatePdf(student.StudentName+" "+student.StudentSurname);
                pdfFile.Open();
               // Borç pdf oluşturan bilgileri
                Author(pdfFile);
                //firma resmi ve tarihi oluştur
                var pdfTableHeader = CreateLogoAndDate(fontArialHeader, fontArial);
                var p = new Phrase("\n");
            //Tabloyu Oluştur
                var pdfTable = CreateTable(student, fontArial);
                // Pdfe yaz ve dosyayı kapat
               WritePdfAndCloseFile(pdfFile, pdfTableHeader, p, pdfTable);
                
            }
            catch (Exception)
            {
                MessageBox.Show(@"Birşeyler Ters Gitti Lütfen Tekrar Deneyin");
            }
        }

        private static PdfPTable CreateLogoAndDate(Font fontArialHeader, Font fontArial)
        {
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
            return pdfTableHeader;
        }

        private static void WritePdfAndCloseFile(Document pdfFile, PdfPTable pdfTableHeader, Phrase p, PdfPTable pdfTable)
        {
            if (pdfFile.IsOpen() == false) pdfFile.Open();
            pdfFile.Add(pdfTableHeader);
            pdfFile.Add(p);
            pdfFile.Add(pdfTable);
            pdfFile.Close();
        }

        private static Font ChooseFont(out Font fontArialHeader, out Font fontArialbold, out Font fontArialboldgeneral)
        {
            var trArial = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\tahoma.ttf", BaseFont.IDENTITY_H,
                BaseFont.NOT_EMBEDDED);
            var fontArial = new Font(trArial, 10, Font.NORMAL, BaseColor.DARK_GRAY);
            fontArialHeader = new Font(trArial, 13, Font.BOLD, BaseColor.BLACK);
            fontArialbold = new Font(trArial, 9, Font.BOLD, BaseColor.DARK_GRAY);
            fontArialboldgeneral = new Font(trArial, 10, Font.BOLD, BaseColor.BLACK);
            return fontArial;
        }

        private static Document CreatePdf(string studentNameSurname)
        {
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

            return pdfFile;
        }

        private static void Author(Document pdfFile)
        { 
            pdfFile.AddCreator("Yönetici"); //Oluşturan kişinin isminin eklenmesi
            pdfFile.AddCreationDate(); //Oluşturulma tarihinin eklenmesi
            pdfFile.AddAuthor("Yönetici"); //Yazarın isiminin eklenmesi
            pdfFile.AddHeader("Başlık", "Sürücü Kursu Otomasyonu");
            pdfFile.AddTitle("Öğrenci Borç Bilgileri"); //Başlık ve title eklenmesi
        }
      
        private static PdfPTable CreateTable(Student student, Font fontArial)
        {
            var pdfTable = new PdfPTable(2)
            {
                TotalWidth = 500f,
                LockedWidth = true
            };
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.DefaultCell.BorderColor = BaseColor.GRAY;

            AddCell("Öğrenci Numarası",student.StudentId.ToString(),fontArial,pdfTable);
            AddCell("Öğrenci Adı Soyadı",student.StudentName+" "+student.StudentSurname,fontArial,pdfTable);
            AddCell("Öğrenci Kimlik Numarası",student.StudentNationalNumber,fontArial,pdfTable);
            AddCell("Öğrenci Kayıt Tarihi",student.RegistrationDate.ToShortDateString(),fontArial,pdfTable);
            AddCell("Kayıt Ücreti",student.StudentDebt.ToString(CultureInfo.InvariantCulture),fontArial,pdfTable);
            AddCell("Kalan Borç",student.StudentTotalDebt.ToString(CultureInfo.InvariantCulture),fontArial,pdfTable);
            AddCell("Taksit Sayısı",student.QuantityInstallment.ToString(),fontArial,pdfTable);
            AddCell("Öğrenci Iban Numarası",student.StudentIbanNumber,fontArial,pdfTable);
            AddCell("İstenen Belge Tipi",student.StudentWantLicenceType,fontArial,pdfTable);
            return pdfTable;
            
        }

        private static void AddCell(string title,string studentProp, Font fontArial, PdfPTable pdfTable)
        {
          
            pdfTable.AddCell(new Phrase(title, fontArial));
            pdfTable.AddCell(new Phrase(studentProp, fontArial));
        }

        private static void ChooseDirectory()
        {
            if (!Directory.Exists(@"c:\SurucuKursu"))
            {
                Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler");
                Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\img");
                Directory.CreateDirectory(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\pdf");
            }
        }

        
    }
}