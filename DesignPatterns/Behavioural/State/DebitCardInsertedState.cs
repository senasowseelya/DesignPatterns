namespace DesignPatterns.Behavioural.State
{
    internal class DebitCardInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("Card ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin entered");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("You can't insert card as it is already inserted");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdrawn successfully");
        }
    }
}
