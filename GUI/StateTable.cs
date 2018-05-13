using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    public class StateTable
    {
        List<State> _states;
        public StateTable()
        {
            _states = new List<State>();
            _states.Add(new State("Q0", 0));
            _states.Add(new State("Q1", 1));
            _states.Add(new State("Q2", 2));
            _states.Add(new State("Q3", 3));
            _states.Add(new State("Q4", 4));
            _states.Add(new State("Q5", 5));
            _states.Add(new State("Q6", 6));
            _states.Add(new State("Q7", 7));
            _states.Add(new State("Q8", 8));
            _states.Add(new State("Q9", 9));
            _states.Add(new State("Q10", 10));
            _states.Add(new State("Q11", 11));
            _states.Add(new State("Q12", 12));

            _states[0].NextStates.AddRange(new List<State>{ _states[1], _states[2], _states[5]});
            _states[1].NextStates.AddRange(new List<State> { _states[2], _states[3], _states[6] });
            _states[2].NextStates.AddRange(new List<State> { _states[3], _states[4], _states[7] });
            _states[3].NextStates.AddRange(new List<State> { _states[4], _states[5], _states[8] });
            _states[4].NextStates.AddRange(new List<State> { _states[5], _states[6], _states[9] });
            _states[5].NextStates.AddRange(new List<State> { _states[6], _states[7], _states[10] });
            _states[6].NextStates.AddRange(new List<State> { _states[7], _states[8], _states[11] });
            _states[7].NextStates.AddRange(new List<State> { _states[8], _states[9], _states[12] });
            _states[8].NextStates.AddRange(new List<State> { _states[9], _states[10], _states[12] });
            _states[9].NextStates.AddRange(new List<State> { _states[10], _states[11], _states[12] });
            _states[10].NextStates.AddRange(new List<State> { _states[11], _states[12], _states[12] });
            _states[11].NextStates.AddRange(new List<State> { _states[12], _states[12], _states[12] });
            _states[12].NextStates.AddRange(new List<State> { _states[12], _states[12], _states[12] });

            _states[6].SetRest(1);
            _states[8].SetRest(1);
            _states[9].SetRest(2);
            _states[10].SetRest(3);
            _states[11].SetRest(4);
            _states[12].SetRest(5);
            _states[5].Proudct = "Herbata";
            _states[6].Proudct = "Herbata";
            _states[7].Proudct = "Kawa";
            _states[8].Proudct = "Kawa";
            _states[9].Proudct = "Kawa";
            _states[10].Proudct = "Kawa";
            _states[11].Proudct = "Kawa";
            _states[12].Proudct = "Kawa";
        }
        public State GetInitialState()
        {
            return _states[0];            
        }
    }
}
