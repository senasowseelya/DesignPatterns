using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator
{
    internal interface IIterator<T>
    {
        T Next();
        bool HasNext(); 
    }
}
