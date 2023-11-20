using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Interpreter
{
    internal class EqualsExpression : IExpression
    {
        private readonly string key;
        private readonly string value;

        public EqualsExpression(string key , string value)
        {
            this.key = key;
            this.value = value;
        }


        public bool Interpret(Dictionary<string, dynamic> context)
        {
            return context.ContainsKey(key) && context[key] == value;
        }
    }
}
