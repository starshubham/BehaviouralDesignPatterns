using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public class DirectorHandler: ILeaveHandler
    {
        private ILeaveHandler? _nextHandler;
        public void SetNext(ILeaveHandler handler)
        {
            _nextHandler = handler;
        }
        public void HandleLeaveRequest(int days)
        {
            if (days <= 10)
            {
                Console.WriteLine($"Director approved leave for {days} day(s).");
            }
            else
            {
                Console.WriteLine($"Director cannot approve leave for {days} day(s). Leave request rejected.");
            }
        }
    }
}

/*
Employee
   |
   v
TeamLead
   |
   | > 2 days
   v
Manager
   |
   | > 5 days
   v
Director
   |
   | > 10 days
   v
Rejected
*/
