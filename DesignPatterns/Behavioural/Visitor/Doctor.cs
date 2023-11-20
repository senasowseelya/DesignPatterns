using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    internal class Doctor : IVisitor
    {
        public void Visit(IElement element)
        {
            Console.WriteLine($"Doctor did check up {((Kid)element).Name}");
        }
    }
}
