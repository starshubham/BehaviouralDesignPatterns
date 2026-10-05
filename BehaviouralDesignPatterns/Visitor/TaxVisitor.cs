using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Visitor
{
    public class TaxVisitor : IVisitor
    {
        public void Visit(Employee employee)
        {
            Console.WriteLine($"Calculating Employee Tax for: {employee.Name}");
        }

        public void Visit(Customer customer)
        {
            Console.WriteLine($"Calculating Customer Tax for: {customer.Name}");
        }
    }
}
