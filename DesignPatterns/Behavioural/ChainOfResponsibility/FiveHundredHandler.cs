using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    internal class FiveHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long notes = requestedAmount / 500;
            if(notes > 0)
            {
                Console.WriteLine($"{notes} five hundred dispatched");
            }
            long pending = requestedAmount % 500;
            if (pending > 0)
            {
                NextHandler.DispatchNote(pending);
            }
        }
    }
}
