using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public class DeliveredState : IOrderState
    {
        public void Process(OrderContext order)
        {
            Console.WriteLine("Order is DELIVERED.");
        }
    }
}
