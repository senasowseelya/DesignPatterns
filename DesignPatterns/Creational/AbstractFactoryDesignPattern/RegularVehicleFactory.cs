using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    //Factory which returns set of objects
    internal class RegularVehicleFactory : IvehicleFactory
    {
        public IBike GetBike()
        {
            return new RegularBike();
        }

        public ICar GetCar()
        {
            return new RegularCar();
        }
    }
}
