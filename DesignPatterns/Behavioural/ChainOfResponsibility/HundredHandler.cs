namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    internal class HundredHandler:Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long notes = requestedAmount / 100;
            if (notes > 0)
            {
                Console.WriteLine($"{notes} hundred dispatched");
            }
        }
    }
}
