using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    internal class TwoWheelerVehicle : Vehicle
    {
        public string Type { get; set; }
        public TwoWheelerVehicle GetClone()
        {
            return (TwoWheelerVehicle)MemberwiseClone();
        }
    }

}
