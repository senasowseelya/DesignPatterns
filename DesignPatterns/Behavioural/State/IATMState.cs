namespace DesignPatterns.Behavioural.State
{
    internal interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void Withdraw();
    }
}
