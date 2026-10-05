using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.TemplateMethod
{
    public class OnlineOrderProcessor : OrderProcessor
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Processing online payment...");
        }
    }
}
