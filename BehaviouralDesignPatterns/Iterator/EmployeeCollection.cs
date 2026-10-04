using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Iterator
{
    /// <summary>
    /// Represents a collection of employees that can be iterated over.
    /// 
    /// This demonstrates an important .NET concept:
    /// IEnumerable<T>
    /// IEnumerator<T>
    /// foreach
    /// </summary>
    public class EmployeeCollection: IEmployeeCollection
    {
        private readonly List<string> _employees =
        new List<string>
        {
            "John",
            "David",
            "Michael",
            "Robert"
        };

        public IEnumerator<string> GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
