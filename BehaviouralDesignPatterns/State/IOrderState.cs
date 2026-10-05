using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public interface IOrderState
    {
        void Process(OrderContext order);
    }
}
