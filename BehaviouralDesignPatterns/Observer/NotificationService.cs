using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Observer
{
    public class NotificationService
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
