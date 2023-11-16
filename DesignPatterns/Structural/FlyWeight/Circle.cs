using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    internal class Circle : IShape
    {
        public string Color { get; set; }

        private readonly int ColorX = 10;

        private readonly int ColorY = 20;

        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine($"{ColorX} {ColorY} {Color}");
        }
    }
}
