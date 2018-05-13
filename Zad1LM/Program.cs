using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1LM
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = new StateTable().GetInitialState();
            int sumOfCoins = 0;
            StringBuilder sb = new StringBuilder();
            List<State> savedStates = new List<State>();
            do
            {
                savedStates.Add(state);
                Console.WriteLine("Jestes w stanie: {0}", state.Name);
                Console.Write("Wprowadź monetę 1,2,5: ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                int value = Convert.ToInt32(key) - 48;
                if (value != 1 && value != 2 && value != 5)
                {
                    Console.WriteLine("W polsce nie ma monet z wartością: {0}", value);
                    continue;
                }
                sumOfCoins += value;
                sb.Append(" -> ").Append(state.Name);
                state = state.NextState(value);
            } while (state.Proudct == null);
            sb.Append(" -> ").Append(state.Name);
            Console.WriteLine("Dane: {0}, wartosc: {1}", sb , sumOfCoins);
            Console.WriteLine("Wydano: " + state.Proudct);
            Console.WriteLine("reszty: " + state.Rest);
            Console.ReadKey();
        }
    }
}
