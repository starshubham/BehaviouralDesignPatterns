using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is OFF.");
        }
    }
}
