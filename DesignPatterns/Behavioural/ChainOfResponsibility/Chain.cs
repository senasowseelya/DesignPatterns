using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    internal class Chain
    {
        private TwoThousandHandler twoThousandHandler;
        private FiveHundredHandler fiveHundredHandler;
        private HundredHandler hundredHandler;

        public Chain() 
        {
            twoThousandHandler = new TwoThousandHandler();
            fiveHundredHandler = new FiveHundredHandler();
            hundredHandler = new HundredHandler();

            twoThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(hundredHandler);

        }

        public void Withdraw(long amount)
        {
            if(amount%100 == 0)
            {
                Console.WriteLine("Valid amount");
                twoThousandHandler.DispatchNote(amount);
            }
            else
            {
                Console.WriteLine("Invalid Amount entered");
            }
        }
    }
}
