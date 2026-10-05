using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Memento
{
    public class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
