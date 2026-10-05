using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public class ShippedState : IOrderState
    {
        public void Process(OrderContext order)
        {
            Console.WriteLine("Order is SHIPPED.");

            order.SetState(new DeliveredState());
        }
    }
}
