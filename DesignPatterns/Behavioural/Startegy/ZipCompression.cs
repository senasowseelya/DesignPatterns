using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Startegy
{
    internal class ZipCompression : ICompression
    {
        public void CompressFolder(string folderName)
        {
            Console.WriteLine($"{folderName} is compressed in Zip Format");
        }
    }
}
