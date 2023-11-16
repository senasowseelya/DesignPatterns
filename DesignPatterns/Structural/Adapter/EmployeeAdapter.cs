using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //We will have both class adapter and object adapter the following is an example of object adapter and
    //if it is class adapter,the adapter class will inherit from adaptee class along with the targer interface and it looks like
    //class EmployeeAdapter : ThirdPartyBillingSystem , ITarget.
    internal class EmployeeAdapter : ITarget
    {
        public void ProcessCompanySalary(string[,] employees)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;
            List<StandardEmployee> listEmployee = new List<StandardEmployee>();
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employees[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employees[i, j];
                    }
                    else if (j == 2)
                    {
                        Designation = employees[i, j];
                    }
                    else
                    {
                        Salary = employees[i, j];
                    }
                }
                listEmployee.Add(new StandardEmployee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            new ThirdPartyBillingSystem().ProcessSalary(listEmployee);
        }
    }
}
