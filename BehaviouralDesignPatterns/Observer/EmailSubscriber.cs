using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Observer
{
    public class EmailSubscriber : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
