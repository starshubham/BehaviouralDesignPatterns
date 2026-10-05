using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (User user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
