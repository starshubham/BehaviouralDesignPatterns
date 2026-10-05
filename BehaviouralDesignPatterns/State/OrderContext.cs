using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviouralDesignPatterns.State
{
    public class OrderContext
    {
        private IOrderState _currentState;

        public OrderContext()
        {
            _currentState = new CreatedState();
        }

        public void SetState(IOrderState state)
        {
            _currentState = state;
        }

        public void Process()
        {
            _currentState.Process(this);
        }
    }
}
