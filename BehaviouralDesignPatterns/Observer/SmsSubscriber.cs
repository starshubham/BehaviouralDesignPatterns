using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Observer
{
    public class SmsSubscriber : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}
