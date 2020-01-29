using GrapeCity.Documents.Pdf;
using System;
using System.IO;

namespace DDExportFormData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DioDocs for PDF. PDF Form Data Export!");

            var doc = new GcPdfDocument();

            // PDFを読み込み
            doc.Load(new FileStream("grapecity_order_embed.pdf", FileMode.Open, FileAccess.Read));

            // FDFファイルとしてデータを出力
            doc.ExportFormDataToFDF("FormData_FDF.fdf");

            // XFDFファイルとしてデータを出力
            doc.ExportFormDataToXFDF("FormData_XFDF.xfdf");

            // XMLファイルとしてデータを出力
            doc.ExportFormDataToXML("FormData_XML.xml"); 
        }
    }
}
