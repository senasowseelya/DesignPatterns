using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FluentInterfaceDesignPattern
{
    internal class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public DateTime BornOn { get; set; }
        public string BornAt { get; set; }
    }
}
