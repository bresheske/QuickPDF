using System;

namespace QuickPDF.Core.Services
{
    public interface IPDFCreator : IDisposable
    {
        void AddImage(string file);
        void ProcessPDF(string outputfile);
    }
}
