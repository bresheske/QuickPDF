using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPDF.Core.Services
{
    public interface IPDFCreator : IDisposable
    {
        void AddImage(string file);
        void ProcessPDF(string outputfile);
    }
}
