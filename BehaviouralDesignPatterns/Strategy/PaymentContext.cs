using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Strategy
{
    public class PaymentContext
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
