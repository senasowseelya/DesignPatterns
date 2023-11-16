using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    internal class Leaf : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Leaf(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"Price {Price} - name {Name}");

        }
    }
}
