using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }

        public Address StudentAddress { get; set; }

        public Student GetClone()
        {
            //Memberwiseclone is from System.object class and is used for shallow copy of an object
            return (Student)MemberwiseClone();
        }

        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.StudentAddress = StudentAddress.GetClone();
            return student;
        }
    }

    public class Address
    {
        public string Country { get; set; }
        public Address GetClone()
        {
            return (Address)MemberwiseClone();
        }
    }
}
