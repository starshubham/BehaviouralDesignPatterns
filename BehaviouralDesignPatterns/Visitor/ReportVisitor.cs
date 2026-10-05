using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Visitor
{
    public class ReportVisitor : IVisitor
    {
        public void Visit(Employee employee)
        {
            Console.WriteLine($"Generating Employee Report for: {employee.Name}");
        }

        public void Visit(Customer customer)
        {
            Console.WriteLine($"Generating Customer Report for: {customer.Name}");
        }
    }
}
