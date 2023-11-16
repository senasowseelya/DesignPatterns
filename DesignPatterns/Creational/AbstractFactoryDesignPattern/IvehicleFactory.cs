using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{

    //AbstarctFactory Class  which acts a contract for creation of set of objects or a factory
    internal interface IvehicleFactory
    {
        IBike GetBike();
        ICar GetCar();
    }
}
