using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public class PaidState : IOrderState
    {
        public void Process(OrderContext order)
        {
            Console.WriteLine("Order is PAID.");

            order.SetState(new ShippedState());
        }
    }
}
