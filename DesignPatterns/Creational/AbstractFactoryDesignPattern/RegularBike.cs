using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    internal class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Bike Details");
        }
    }
}
