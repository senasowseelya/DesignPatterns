using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    internal class FourWheelerVehicle : Vehicle
    {
        public string model { get; set; }
        public FourWheelerVehicle GetClone()
        {
            return (FourWheelerVehicle)MemberwiseClone();
        }
    }
}
