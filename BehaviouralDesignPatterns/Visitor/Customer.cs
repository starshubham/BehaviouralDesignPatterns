using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Visitor
{
    public class Customer : IEntity
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
