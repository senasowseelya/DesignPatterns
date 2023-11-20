using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    abstract class BuildHouseTemplate
    {
        public void Build()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
        }
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}
