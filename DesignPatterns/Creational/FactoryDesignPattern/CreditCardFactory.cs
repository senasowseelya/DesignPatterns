using System;
using System.Collections.Generic;
using System.Linq;
namespace DesignPatterns.Creational.FactoryDesignPattern
{
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType == "Gold")
            {
                creditCard = new GoldCreditCard();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new PlatinumCreditCard();
            }

            else if (cardType == "Titanium")
            {
                creditCard = new TitaniumCreditCard();
            }
            else
            {
                creditCard = null;
            }
            return creditCard;
        }

    }
}
