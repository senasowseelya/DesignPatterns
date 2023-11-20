using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    internal class SalesMan : IVisitor
    {
        public void Visit(IElement element)
        {
            Console.WriteLine($"Salesman sold bag to {((Kid)element).Name} ");
        }
    }
}
