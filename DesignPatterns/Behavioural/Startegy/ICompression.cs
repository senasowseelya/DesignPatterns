using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Startegy
{
    internal interface ICompression
    {
        public void CompressFolder(string folderName);
    }
}
