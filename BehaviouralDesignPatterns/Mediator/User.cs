using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Mediator
{
    public class User
    {
        private readonly IChatMediator _mediator;

        public string Name { get; }

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} sent: {message}");

            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} received: {message}");
        }
    }
}
