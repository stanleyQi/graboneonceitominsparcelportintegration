using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using tools.objects.parcelport;

namespace tools.helper
{
    class PrintHelper
    {
        /// <summary>
        /// perform print silently on the printer
        /// </summary>
        /// <param name="msg"></param>
        public async Task<string> PerformPrint(List<ConsignmentRep> consignmentReps, List<LabelAddress> lables)
        {
            //List<string> faults = new List<string>();
            string combinedPdfFilePath = "";
            //string consignmentRef = consignmentReps[0].consignmentRef[0];
            string now = DateTime.Now.ToString("yyyy-MM-dd HH mm ss");

            //download and store the files which want to print
            try
            {
                string LocalFolderName = string.Format(@"C:\ParcelPortPrinterTemp\{0}", now);
                List<string> pdfFileNames = new List<string>();
                foreach (var remoteLable in lables)
                {
                    string requestUri = remoteLable.url;
                    string LocalFilePath = string.Format(@"{0}\{1}.pdf", LocalFolderName, remoteLable.ToString());

                    if (!Directory.Exists(LocalFolderName))
                        Directory.CreateDirectory(LocalFolderName);

                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage response = await client.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                        using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
                        {
                            // local address
                            using (Stream streamToWriteTo = File.Open(LocalFilePath, FileMode.Create))
                            {
                                await streamToReadFrom.CopyToAsync(streamToWriteTo);
                                pdfFileNames.Add(LocalFilePath);
                            }
                        }
                    }
                }
                //combine pdfs downloaded into one pdf
                combinedPdfFilePath = string.Format(@"{0}\Combine-{1}.pdf", LocalFolderName, now);
                MergePDFs(combinedPdfFilePath, pdfFileNames.ToArray<string>());
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            bool result = false;
            //get printer instant->setting->perform print
            try
            {
                result = SettingAndPerformPrint(combinedPdfFilePath);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            return combinedPdfFilePath;
        }
        private static void MergePDFs(string targetPath, params string[] pdfs)
        {
            using (PdfSharp.Pdf.PdfDocument targetDoc = new PdfSharp.Pdf.PdfDocument())
            {
                foreach (string pdf in pdfs)
                {
                    using (PdfSharp.Pdf.PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                targetDoc.Save(targetPath);
            }
        }
        private bool SettingAndPerformPrint(string combinedPdfFilePath)
        {
           bool result = false;
            string printerName = "Microsoft Print to PDF";
            string paperName = "Letter";

            // Create the printer settings for our printer
            var printerSettings = new PrinterSettings
            {
                PrinterName = printerName,
                Copies = 1
            };

            // Create our page settings for the paper size selected
            var pageSettings = new PageSettings(printerSettings)
            {
                Margins = new Margins(0, 0, 0, 0)
            };
            foreach (PaperSize paperSize in printerSettings.PaperSizes)
            {
                if (paperSize.PaperName == paperName)
                {
                    pageSettings.PaperSize = paperSize;
                    break;
                }
            }

            try
            {
                // Now print the PDF document
                using (var document = PdfiumViewer.PdfDocument.Load(combinedPdfFilePath))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
