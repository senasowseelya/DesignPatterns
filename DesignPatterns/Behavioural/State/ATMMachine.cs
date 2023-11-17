using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.State
{
    internal class ATMMachine:IATMState
    {
        IATMState atmState = null;
        public ATMMachine() 
        {
            atmState = new DebitCardNotInsertedState();
        }

        public void EjectDebitCard()
        {
            atmState.EjectDebitCard();
            if(atmState is DebitCardInsertedState)
            {
                atmState = new DebitCardNotInsertedState();
            }
            
        }

        public void EnterPin()
        {
            atmState.EnterPin();
        }

        public void InsertDebitCard()
        {
           atmState.InsertDebitCard();
            if(atmState is DebitCardNotInsertedState)
            {
                atmState = new DebitCardInsertedState();
            }
        }

        public void Withdraw()
        {
            atmState.Withdraw();
        }
    }
}
