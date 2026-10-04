using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Interpreter
{
    public class AndExpression : IExpression
    {
        private readonly IExpression _first;
        private readonly IExpression _second;

        public AndExpression(IExpression first, IExpression second)
        {
            _first = first;
            _second = second;
        }

        public bool Interpret(string context)
        {
            return _first.Interpret(context) && _second.Interpret(context);
        }
    }
}
