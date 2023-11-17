using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.State
{
    internal class DebitCardNotInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("Cant eject as it is not inserted");
        }

        public void EnterPin()
        {
            Console.WriteLine("Cant enter pin as card is not inserted");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("Card Inserted");
        }

        public void Withdraw()
        {
            Console.WriteLine("Cant withdraw as card is not inserted");
        }
    }
}
