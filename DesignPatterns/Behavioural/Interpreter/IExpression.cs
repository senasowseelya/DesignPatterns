namespace DesignPatterns.Behavioural.Interpreter
{
    internal interface IExpression
    {
        public bool Interpret(Dictionary<string ,dynamic> context);
    }
}
