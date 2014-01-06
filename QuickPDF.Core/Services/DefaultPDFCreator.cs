using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Collections.Generic;

namespace QuickPDF.Core.Services
{
    /// <summary>
    /// Object is responsible for taking a list of images and converting it to a 
    /// multi-page PDF Document.
    /// </summary>
    public class DefaultPDFCreator : IPDFCreator
    {
        private readonly List<string> files;

        public DefaultPDFCreator()
        {
            files = new List<string>();
        }

        /// <summary>
        /// Adds a file to the Image list.  
        /// </summary>
        /// <param name="file"></param>
        public void AddImage(string file)
        {
            files.Add(file);
        }

        /// <summary>
        /// Converts the image list into a multi-page PDF file.
        /// </summary>
        /// <param name="outputfile"></param>
        public void ProcessPDF(string outputfile)
        {
            var doc = new PdfDocument();
            foreach (var f in files)
            {
                var p = doc.AddPage();
                using (var gfx = XGraphics.FromPdfPage(p))
                using (var img = XImage.FromFile(f))
                {
                    gfx.DrawImage(img, 0, 0);
                }
            }
            doc.Save(outputfile);
        }

        /// <summary>
        /// Just clears out the file list.
        /// </summary>
        public void Dispose()
        {
            files.Clear();
        }
    }
}