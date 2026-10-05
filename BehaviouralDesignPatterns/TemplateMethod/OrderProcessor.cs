using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.TemplateMethod
{
    public abstract class OrderProcessor
    {
        // Template Method
        public void ProcessOrder()
        {
            ValidateOrder();

            ProcessPayment();

            ShipOrder();

            SendNotification();
        }

        protected virtual void ValidateOrder()
        {
            Console.WriteLine("Validating order...");
        }

        protected abstract void ProcessPayment();

        protected virtual void ShipOrder()
        {
            Console.WriteLine("Shipping order...");
        }

        protected virtual void SendNotification()
        {
            Console.WriteLine("Sending order notification...");
        }
    }
}
