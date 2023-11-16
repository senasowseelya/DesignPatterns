using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    internal class Composite : IComponent
    {
        public string Name { get; set; }
        public Composite(string name)
        {
            this.Name = name;
        }
        public List<IComponent> components = new List<IComponent>();

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
