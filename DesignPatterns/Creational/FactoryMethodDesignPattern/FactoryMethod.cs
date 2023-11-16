using DesignPatterns.Creational.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
    internal abstract class FactoryMethod
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return MakeProduct();

        }
    }
}
