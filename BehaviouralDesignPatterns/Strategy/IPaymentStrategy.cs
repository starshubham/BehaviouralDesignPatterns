using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
