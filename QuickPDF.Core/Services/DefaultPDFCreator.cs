using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPDF.Core.Services
{
    public class DefaultPDFCreator : IPDFCreator
    {
        private readonly List<string> files;

        public DefaultPDFCreator()
        {
            files = new List<string>();
        }

        public void AddImage(string file)
        {
            files.Add(file);
        }

        public void ProcessPDF(string outputfile)
        {
            
        }

        public void Dispose()
        {
            files.Clear();
        }
    }
}
