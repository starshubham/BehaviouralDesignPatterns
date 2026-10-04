using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public interface ILeaveHandler
    {
        void SetNext(ILeaveHandler handler);

        void HandleLeaveRequest(int days);
    }
}
