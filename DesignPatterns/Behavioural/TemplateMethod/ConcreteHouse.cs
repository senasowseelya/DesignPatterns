using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    internal class ConcreteHouse : BuildHouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Concrete Build Foundation");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Concrete Build Pillars");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Concrete Build Walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Concrete Build Windows");
        }
    }
}
