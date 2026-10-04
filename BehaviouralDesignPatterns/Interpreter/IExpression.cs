using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Interpreter
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
