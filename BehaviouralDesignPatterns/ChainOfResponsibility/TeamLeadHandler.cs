using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    internal class TeamLeadHandler: ILeaveHandler
    {
        private ILeaveHandler? _nextHandler;
        public void SetNext(ILeaveHandler handler)
        {
            _nextHandler = handler;
        }
        public void HandleLeaveRequest(int days)
        {
            if (days <= 2)
            {
                Console.WriteLine($"Team Lead approved leave for {days} day(s).");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"Team Lead cannot approve leave for {days} day(s). Forwarding to the next handler.");
                _nextHandler.HandleLeaveRequest(days);
            }
            else
            {
                Console.WriteLine($"No handler available to approve leave for {days} day(s).");
            }
        }
    
    }
}
