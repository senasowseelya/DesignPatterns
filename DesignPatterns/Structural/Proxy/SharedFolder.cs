using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{

    internal class SharedFolder : ISharedFolder
    {
        public void ReadWriteToSharedFolder()
        {
            Console.WriteLine("Read write operation performed to shared folder");
        }
    }
}
