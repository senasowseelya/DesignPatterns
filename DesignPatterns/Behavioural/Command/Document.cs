using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{

    //Receiver Object
    internal class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        public void Close() { 
            Console.WriteLine("Document Closed");
        }

        public void Save() {
            Console.WriteLine("Document Saved");
        }
    }
}
