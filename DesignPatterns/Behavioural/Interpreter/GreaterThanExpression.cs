using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Interpreter
{
    public class GreaterThanExpression : IExpression
    {
        private readonly string key;
        private readonly int value;

        public GreaterThanExpression(string key , int value)
        {
            this.key = key;
            this.value = value;
        }
        public bool Interpret(Dictionary<string, dynamic> context)
        {
            return context.ContainsKey(key) && context[key] > value;
        }
    }
}
