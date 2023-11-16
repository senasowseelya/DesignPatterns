using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FluentInterfaceDesignPattern
{
    internal class FluentEmployee
    {
        public Employee employee = new Employee();

        public FluentEmployee Id(int Id)
        {
            employee.Id = Id;
            return this;
        }

        public FluentEmployee Name(string name)
        {
            employee.Name = name;
            return this;
        }

        public FluentEmployee Age(int age)
        {
            employee.Age = age;
            return this;
        }

        public FluentEmployee BornOn(DateTime date)
        {
            employee.BornOn = date;
            return this;
        }

        public FluentEmployee BornAt(string place)
        {
            employee.BornAt = place;
            return this;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {employee.Name}, \nDateOfBirth: {employee.BornOn}, \nDepartment: {employee.BornAt}, \nAddress: {employee.Age}");
        }
    }
}
