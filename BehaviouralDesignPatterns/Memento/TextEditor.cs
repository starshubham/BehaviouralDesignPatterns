using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Memento
{
    public class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Write(string text)
        {
            Content += text;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(Content);
        }

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }
}
