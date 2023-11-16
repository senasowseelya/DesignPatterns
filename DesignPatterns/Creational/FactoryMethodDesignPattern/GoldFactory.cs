using DesignPatterns.Creational.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
    internal class GoldFactory : FactoryMethod
    {
        protected override ICreditCard MakeProduct()
        {
            return new GoldCreditCard();
        }
    }
}
