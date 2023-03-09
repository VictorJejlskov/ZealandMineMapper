using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeStateMachine
{
    public class StateMachineTable : IStateMachine<InputType>
    {
        private int currentState = 0;
        private StateMachineEntry[,] _sm;

        public StateMachineTable()
        {
            _sm = new StateMachineEntry[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _sm[i, j] = new StateMachineEntry() { NextState = 4, NextMove = new Move(0, 0) };
                }
            }
            _sm[0, 0] = new StateMachineEntry() { NextState = 3, NextMove = new Move(-1, 0) };
            _sm[1, 0] = new StateMachineEntry() { NextState = 0, NextMove = new Move(0, -1) };
            _sm[2, 0] = new StateMachineEntry() { NextState = 1, NextMove = new Move(1, 0) };
            _sm[3, 0] = new StateMachineEntry() { NextState = 0, NextMove = new Move(0, -1) };

            _sm[0, 1] = new StateMachineEntry() { NextState = 0, NextMove = new Move(0, -1) };
            _sm[1, 1] = new StateMachineEntry() { NextState = 1, NextMove = new Move(1, 0) };
            _sm[2, 1] = new StateMachineEntry() { NextState = 2, NextMove = new Move(0, 1) };
            _sm[3, 1] = new StateMachineEntry() { NextState = 1, NextMove = new Move(1, 0) };

            _sm[0, 2] = new StateMachineEntry() { NextState = 1, NextMove = new Move(1, 0) };
            _sm[1, 2] = new StateMachineEntry() { NextState = 2, NextMove = new Move(0, 1) };
            _sm[2, 2] = new StateMachineEntry() { NextState = 3, NextMove = new Move(-1, 0) };
            _sm[3, 2] = new StateMachineEntry() { NextState = 2, NextMove = new Move(0, 1) };

            _sm[0, 3] = new StateMachineEntry() { NextState = 2, NextMove = new Move(0, 1) };
            _sm[1, 3] = new StateMachineEntry() { NextState = 3, NextMove = new Move(-1, 0) };
            _sm[2, 3] = new StateMachineEntry() { NextState = 0, NextMove = new Move(0, -1) };
            _sm[3, 3] = new StateMachineEntry() { NextState = 3, NextMove = new Move(-1, 0) };
        }
        public string CurrentState()
        {
            switch (currentState)
            {
                case 0: return "North";
                case 1: return "East";
                case 2: return "South";
                case 3: return "West";
                default: return "North";
            }
        }

        public Move NextInput(InputType input)
        {
            StateMachineEntry entry = _sm[ConvertInput(input), currentState];
            currentState = entry.NextState;
            return entry.NextMove;
        }
        private int ConvertInput(InputType c)
        {
            switch (c)
            {
                case InputType.Left: return 0;
                case InputType.Forward: return 1;
                case InputType.Right: return 2;
                default: return 3;
            }
        }
    }
    struct StateMachineEntry
    {
        public int NextState;
        public Move NextMove;
    }
}
