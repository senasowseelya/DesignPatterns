using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryDesignPattern
{
    internal interface ICreditCard
    {
        public int GetCreditLimit();
        public int GetAnnualCharge();
        public string GetCardType();
    }
}
