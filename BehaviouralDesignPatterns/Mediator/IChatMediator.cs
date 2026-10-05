using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Mediator
{
    public interface IChatMediator
    {
        void RegisterUser(User user);

        void SendMessage(string message, User sender);
    }
}
