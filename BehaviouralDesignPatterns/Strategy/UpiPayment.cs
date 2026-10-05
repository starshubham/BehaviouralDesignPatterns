using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Strategy
{
    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of ₹{amount} completed using UPI.");
        }
    }
}
