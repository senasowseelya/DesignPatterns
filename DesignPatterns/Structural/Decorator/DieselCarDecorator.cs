using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    internal class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            base.ManufactureCar();
            AddEngine(_car);
            return _car;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void AddEngine(ICar car)
        {
            if(_car is BMWCar bmwCar)
            {
                bmwCar.Engine = "Diesel Engine";
                Console.WriteLine("From Diesel Engine and diesel car decorator" +car);
            }
        }
    }
}
