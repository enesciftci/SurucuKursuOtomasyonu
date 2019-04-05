using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using Font = iTextSharp.text.Font;
using Rectangle = iTextSharp.text.Rectangle;


namespace SurucuKursu.InformationService.DocumentExporter
{
    
 public static class ExportByPdf
    {
       
       public static void CreatDebtPdf(string studentNumber,string studentNameSurname,string studentNationalNumber,string registrationDate,string studentDebt,string studentTotalDebt,string studentQuantityInstallment,string studentIbanNumber,string studentWantLicenceType )
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
                BaseFont trArial = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font fontArial = new Font(trArial, 10, Font.NORMAL, BaseColor.DARK_GRAY);
                Font fontArialHeader = new Font(trArial, 13, Font.BOLD, BaseColor.BLACK);
                Font fontArialbold = new Font(trArial, 9, Font.BOLD, BaseColor.DARK_GRAY);
                Font fontArialboldgeneral = new Font(trArial, 10, Font.BOLD, BaseColor.BLACK);
                #endregion

                #region Fatura pdf oluştur
                Document pdfFile = new Document();
                try
                {
                    PdfWriter.GetInstance(pdfFile, new FileStream(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\pdf\" + studentNameSurname + ".pdf", FileMode.CreateNew));
                }
                catch (Exception)
                {
                  var dialog=  MessageBox.Show(@"Aynı İsimli Dosya Mevcut Üzerine Yazılsın Mı ?", @"Uyarı",
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

                #region Fatura oluşturan bilgileri
                pdfFile.AddCreator("Yönetici"); //Oluşturan kişinin isminin eklenmesi
                pdfFile.AddCreationDate();//Oluşturulma tarihinin eklenmesi
                pdfFile.AddAuthor("Yönetici"); //Yazarın isiminin eklenmesi
                pdfFile.AddHeader("Başlık", "Sürücü Kursu Otomasyonu");
                pdfFile.AddTitle("Öğrenci Borç Bilgileri"); //Başlık ve title eklenmesi
                #endregion

                #region Fatura firma resmi ve tarihi oluştur
                iTextSharp.text.Image jpgimg = iTextSharp.text.Image.GetInstance(@"C:\Users\İbrahim Enes Çiftçi\Desktop\surcukursuresimler\img\logo.png");
                jpgimg.ScalePercent(35);
                jpgimg.Alignment = iTextSharp.text.Image.LEFT_ALIGN;

                PdfPTable pdfTableHeader = new PdfPTable(3)
                {
                    TotalWidth = 500f,
                    LockedWidth = true
                };
                pdfTableHeader.DefaultCell.Border = Rectangle.NO_BORDER;

                PdfPCell cellheader1 = new PdfPCell(jpgimg)
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_BOTTOM,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader1);

                PdfPCell cellheader2 = new PdfPCell(new Phrase("Öğrenci Borç Bilgileri", fontArialHeader))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader2);


                PdfPCell cellheader3 = new PdfPCell(new Phrase(DateTime.Now.ToShortDateString(), fontArial))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    FixedHeight = 60f,
                    Border = 0
                };
                pdfTableHeader.AddCell(cellheader3);
                #endregion

                Phrase p = new Phrase("\n");

                #region Tabloyu Oluştur
                PdfPTable pdfTable = new PdfPTable(2)
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
           
        }
        /* private static void Export()
         {
             #region CommonPart 
             PdfPTable _pdfPTable = new PdfPTable(1);
             PdfPTable _pdfPTableFooter = new PdfPTable(1);
             _pdfPTableFooter.DefaultCell.BorderWidth = 0;
             _pdfPTableFooter.WidthPercentage = 100;
             _pdfPTableFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

             Chunk cnkFooter = new Chunk("Sürücü Kursu Otomasyonu", FontFactory.GetFont("Times New Roman"));
             cnkFooter.Font.Size = 10;
             _pdfPTableFooter.AddCell(new Phrase(cnkFooter));
             _pdfPTableFooter.AddCell(new Phrase(" "));
             _pdfPTableFooter.DefaultCell.Border = 0;


             #endregion

             #region Page

             #region Section-1 <Header FORM>

             PdfPTable pdfPTable1 = new PdfPTable(1);
             PdfPTable pdfPTable2=new PdfPTable(1);
             PdfPTable pdfPTable3=new PdfPTable(2);
           System.Drawing.Font fontH1=new System.Drawing.Font("Currier",16);


             pdfPTable1.WidthPercentage = 80;
             pdfPTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
             pdfPTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
             pdfPTable1.DefaultCell.BorderWidth = 0;

             pdfPTable2.WidthPercentage = 80;
             pdfPTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
             pdfPTable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
             pdfPTable2.DefaultCell.BorderWidth = 0;

             pdfPTable3.DefaultCell.Padding = 5;
             pdfPTable3.WidthPercentage = 80;
             pdfPTable3.DefaultCell.BorderWidth = 0.5f;

             Chunk chunk1=new Chunk("Sürücü Kursu Otomasyonu",FontFactory.GetFont("Times New Roman"));
             chunk1.Font.Color=new iTextSharp.text.BaseColor(0,0,0);
             chunk1.Font.SetStyle(0);
             chunk1.Font.Size = 14;
             Phrase phrase1 = new Phrase();
             phrase1.Add(chunk1);
             pdfPTable1.AddCell(phrase1);

             Chunk chunk2=new Chunk();

             #endregion


             #endregion

             Document _document = new Document(iTextSharp.text.PageSize.A4, 20f, 20f, 30f, 30f);
         PdfWriter pdf = PdfWriter.GetInstance(_document, new FileStream(@"C:\\Debt.pdf", FileMode.Create));

         }*/
    }


}
