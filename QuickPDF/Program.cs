using QuickPDF.Core.Services;
using System;
using System.IO;
using System.Linq;

namespace QuickPDF.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO: IOC probably more appropriate here.
            // Special thanks to PDFSharp!
            // http://www.nuget.org/packages/PDFsharp/
            var pdf = new DefaultPDFCreator();

            // First is output file.
            var output = args.First();
            if (!Path.IsPathRooted(output))
                output = Environment.CurrentDirectory + @"\" + output;

            // Rest is image files.
            var files = args.Skip(1);

            foreach (var f in files)
            {
                // If file is relative, use our environment path.
                var file = f;
                if (!Path.IsPathRooted(file))
                    file = Environment.CurrentDirectory + @"\" + f;
                // Add it to our list.
                pdf.AddImage(f);
            }

            // Finish up.
            pdf.ProcessPDF(output);
            pdf.Dispose();
        }
    }
}
