using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Startegy
{
    internal class CompressionContext
    {
        private ICompression compression;

        public CompressionContext(ICompression compression)
        {
            this.compression = compression;
        }

        //Setter method for strategy
        public void SetStrategy(ICompression compression)
        {
            this.compression = compression;
        }

        public void CreateCompressedFolder(string folderName)
        {
            this.compression.CompressFolder(folderName);
        }
    }
}
