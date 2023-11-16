using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    internal class RegularCar : ICar
    {
        public void GetCarDetails()
        {
            Console.WriteLine("Regular Car Details");
        }
    }
}
