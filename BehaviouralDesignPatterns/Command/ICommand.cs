using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
