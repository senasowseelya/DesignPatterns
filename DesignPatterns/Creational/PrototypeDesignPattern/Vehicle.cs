using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public Vehicle GetClone()
        {
            return (Vehicle)MemberwiseClone();
        }
    }
}
