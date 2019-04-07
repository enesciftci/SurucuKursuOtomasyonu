using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.Information.Concrete.DocumentExporter
{
    public class ExportWithPrinter : IExportWithPrinterService
    {
        private IExportByPdfService _exportByPdfService = InstanceFactory.GetInstance<IExportByPdfService>();
        private static PrintDocument _printDocument;
        private static PrintDialog _dialog;
        private static FileDialog _browser;
        private static string _filePath;

        public void PrintPdf()
        {
            _printDocument = new PrintDocument();
            _printDocument.PrintPage += printDocument_PrintPage;
            _browser = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                RestoreDirectory = true,
                Filter = @"Pdf Dosyası|*.pdf"
            };
            _dialog = new PrintDialog
            {
                Document = _printDocument
            };
            if (_browser.ShowDialog() == DialogResult.OK && _dialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = _browser.FileName;
                _printDocument.Print();
            }

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var print = new Process();
            print.StartInfo.FileName = _filePath;
            print.StartInfo.Verb = "print";
            print.Start();
        }
    }
}