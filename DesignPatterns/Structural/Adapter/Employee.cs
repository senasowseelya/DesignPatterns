using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    internal class StandardEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public StandardEmployee(int id, string name, string designation, decimal salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }


    }
}
