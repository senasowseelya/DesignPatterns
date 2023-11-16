using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    internal class ConcreteObserver : IObserver
    {
        public int Id { get; set; }
        public void Update()
        {
            Console.WriteLine($"Update method called for {Id}");
        }
    }
}
