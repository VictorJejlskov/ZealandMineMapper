using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeStateMachine
{
    public interface IStateMachine<T>
    {
        Move NextInput(T input);
        string CurrentState();
    }
}
