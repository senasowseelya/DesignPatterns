using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SingletonDesignPattern
{
    public sealed class SingletonDemo
    {
        public long Id { get; set; }
        public static SingletonDemo instance { get; set; } = new SingletonDemo
        {
            Id = DateTime.Now.Ticks
        };

        private SingletonDemo()
        {
            Console.WriteLine("Constructor called");
        }
        public SingletonDemo GetClone()
        {
            return (SingletonDemo)MemberwiseClone();
        }

    }



}
