using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    internal class SportsCar : ICar
    {
        public void GetCarDetails()
        {
            Console.WriteLine("Sports Car Details");
        }
    }
}
