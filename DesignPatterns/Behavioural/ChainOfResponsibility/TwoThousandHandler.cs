using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    internal class TwoThousandHandler:Handler
    {
        public override void DispatchNote(long amount)
        {
            long notesToBeDispatched = amount / 2000;
            if(notesToBeDispatched > 0)
            {
                Console.WriteLine($" { notesToBeDispatched} Two thousands dispatched");
            }
            long pendingAmount = amount % 2000;
            if (pendingAmount >0 )
            {
                NextHandler.DispatchNote(pendingAmount);
            }

        }

        
    }
}
