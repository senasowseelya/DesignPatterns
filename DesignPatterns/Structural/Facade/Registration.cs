using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class Registration
    {
        public void RegisterCustomer(Customer customer)
        {
            Console.WriteLine($"Registered Successfully customer {customer.Name}");
        }
    }
}
