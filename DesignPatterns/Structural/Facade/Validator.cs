using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            if (customer != null && customer.Name.Length >= 3)
                return true;
            return false;
        }
    }
}
