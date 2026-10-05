using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Visitor
{
    public interface IEntity
    {
        void Accept(IVisitor visitor);
    }
}
