using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    internal class School
    {
        List<IElement> elements = new List<IElement>();
        public School()
        {
            elements = new List<IElement> {
                 new Kid(){ Name = "Prem"},
                 new Kid(){ Name = "Krishna"},
                 new Kid(){ Name = "Radha"}
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                visitor.Visit(element);
            }
        }
    }
}
