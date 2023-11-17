using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    abstract class Handler
    {
        public Handler NextHandler { get; set; }
        public void SetNextHandler(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }
        public abstract void DispatchNote(long requestedAmount);
    }
}
