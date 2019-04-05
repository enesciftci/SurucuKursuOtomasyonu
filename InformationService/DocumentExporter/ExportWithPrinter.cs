using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SurucuKursu.InformationService.DocumentExporter
{
   
   public static class ExportWithPrinter
   {
       private static PrintDocument _printDocument;
       private static PrintDialog _dialog;
       private static FileDialog _browser;
       private static string filePath;
        public static void PrintPdf()
        {
           _printDocument=new PrintDocument();
            _printDocument.PrintPage+=new PrintPageEventHandler(printDocument_PrintPage);
            _browser=new OpenFileDialog();
            _browser.InitialDirectory = Application.StartupPath;
            _browser.RestoreDirectory = true;
            _browser.Filter = @"Pdf Dosyası|*.pdf";
            _dialog = new PrintDialog();
            _dialog.Document = _printDocument;
            if (_browser.ShowDialog() == DialogResult.OK && _dialog.ShowDialog()==DialogResult.OK)
            {
                filePath = _browser.FileName;
               _printDocument.Print();
            }

           // MessageBox.Show(filePath);
            
            
        }

        private static void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            var print = new Process();
            print.StartInfo.FileName = filePath;
            print.StartInfo.Verb = "print";
            print.Start();
        }
    }
 
}
