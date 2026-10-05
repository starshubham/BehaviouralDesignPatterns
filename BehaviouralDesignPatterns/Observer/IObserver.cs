using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }
}
