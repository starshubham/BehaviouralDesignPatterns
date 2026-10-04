using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Interpreter
{
    public class TerminalExpression : IExpression
    {
        private readonly string _value;

        public TerminalExpression(string value)
        {
            _value = value;
        }

        public bool Interpret(string context)
        {
            return context.Contains(_value, StringComparison.OrdinalIgnoreCase);
        }
    }
}
