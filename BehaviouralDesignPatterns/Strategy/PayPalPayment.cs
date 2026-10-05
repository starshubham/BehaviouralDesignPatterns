using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of ₹{amount} completed using PayPal.");
        }
    }
}
