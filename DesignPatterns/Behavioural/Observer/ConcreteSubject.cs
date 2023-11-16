using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    internal class ConcreteSubject : ISubject
    {
        private readonly Product product;
        public List<IObserver> Observers = new List<IObserver>();


        public ConcreteSubject(Product product)
        {
            this.product = product;
        }
        public void AddObserver(IObserver observer)
        {
            Console.WriteLine($"Observer Added {((ConcreteObserver)observer).Id}");
            Observers.Add(observer);  
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine($"Observer Removed {((ConcreteObserver)observer).Id}");
            Observers.Remove(observer);
        }

        public void UpdateProductAvailabilty()
        {
            this.product.State = ProductState.Available;
            NotifyObservers();
        }

    }
}
