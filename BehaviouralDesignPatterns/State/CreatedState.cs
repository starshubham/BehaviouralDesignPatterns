using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public class CreatedState : IOrderState
    {
        public void Process(OrderContext order)
        {
            Console.WriteLine("Order is CREATED.");

            order.SetState(new PaidState());
        }
    }
}
