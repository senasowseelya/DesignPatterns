using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class CustomerFacade
    {
        public void RegisterCustomer(Customer customer)
        {
            bool isValid = new Validator().ValidateCustomer(customer);
            if (isValid)
            {
                new Registration().RegisterCustomer(customer);
                Console.WriteLine("Registered Successfully");
            }

        }
    }
}
