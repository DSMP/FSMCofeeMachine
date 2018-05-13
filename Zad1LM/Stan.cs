using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1LM
{
    public class State
    {
        public List<State> NextStates { get; set; }
        public string Name { get; private set; }
        int _value;
        public int Rest { get; private set; }
        public string Proudct { get; set; }
        public State()
        {
            NextStates = new List<State>();
        }
        public State(string name, int value, List<State> nexts) : this()
        {
            Name = name;
            _value = value;
            NextStates = nexts;
        }
        public State(string name, int value) : this()
        {
            Name = name;
            _value = value;
        }
        public void SetRest(int rest)
        {
            Rest = rest;            
        }
        public State NextState(int value)
        {
            value = value + _value;
            foreach (var nextState in NextStates)
            {
                if (nextState._value.Equals(value))
                {
                    return nextState;
                }
            }
            return this;
        }
    }
}
