using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    //Factory which returns Set of Objects.
    internal class SportsVehicleFactory : IvehicleFactory
    {
        public IBike GetBike()
        {
            return new SportsBike();
        }

        public ICar GetCar()
        {
            return new SportsCar();
        }
    }
}
