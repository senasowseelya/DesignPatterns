using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Interpreter
{
    internal class AndExpression : IExpression
    {
        private readonly IExpression expr1;
        private readonly IExpression expr2;

        public AndExpression(IExpression expr1 ,IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool Interpret(Dictionary<string, dynamic> context)
        {
            return expr1.Interpret(context) && expr2.Interpret(context);
        }
    }
}
