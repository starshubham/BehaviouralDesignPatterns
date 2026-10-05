using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.TemplateMethod
{
    public class CashOnDeliveryProcessor : OrderProcessor
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Payment will be collected during delivery.");
        }
    }
}
