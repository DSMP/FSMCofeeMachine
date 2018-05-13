using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    public class State
    {
        public List<State> NextStates { get; set; }
        public string Name { get; private set; }
        public int Value { get; private set; }
        public int Rest { get; private set; }
        public string Proudct { get; set; }
        public State()
        {
            NextStates = new List<State>();
        }
        public State(string name, int value, List<State> nexts) : this()
        {
            Name = name;
            Value = value;
            NextStates = nexts;
        }
        public State(string name, int value) : this()
        {
            Name = name;
            Value = value;
        }
        public void SetRest(int rest)
        {
            Rest = rest;
        }
        public int GetRest(int productValue)
        {
            return Value - productValue;
        }
        public State NextState(int value)
        {
            value = value + Value;
            foreach (var nextState in NextStates)
            {
                if (nextState.Value.Equals(value))
                {
                    return nextState;
                }
            }
            return this;
        }
    }
}
