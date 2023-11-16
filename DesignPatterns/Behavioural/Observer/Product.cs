using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductState State { get; set; }
    }

    public enum ProductState
    {
        Available,
        SoldOut
    }
}
