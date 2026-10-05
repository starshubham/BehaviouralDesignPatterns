using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Employee employee);

        void Visit(Customer customer);
    }
}
