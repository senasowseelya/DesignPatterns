using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    internal class WoodHouse:BuildHouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Wood Build Foundation");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Wood Build Pillars");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Wood Build Walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Wood Build Windows");
        }
    }
}
