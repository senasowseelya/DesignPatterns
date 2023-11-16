using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator
{
    internal interface IAggregate<T> 
    {
        public IIterator<T> CreateIterator();
    }
}
