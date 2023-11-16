using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    internal class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<StandardEmployee> employees)
        {
            foreach (StandardEmployee employee in employees)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
