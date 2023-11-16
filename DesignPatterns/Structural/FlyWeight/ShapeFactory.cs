using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    internal class ShapeFactory
    {
        private static Dictionary<string ,IShape> ShapeMap = new Dictionary<string, IShape> ();

        public static IShape GetShape()
        {
            IShape shape = null;
            if(!ShapeMap.TryGetValue("Circle",out shape))
            {
                shape = new Circle();
                ShapeMap.Add("Circle",shape);
                Console.WriteLine("new Object");
            }
            return shape;
        }
    }
}
