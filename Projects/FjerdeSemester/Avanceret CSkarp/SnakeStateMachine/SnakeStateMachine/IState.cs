using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeStateMachine
{
    public interface IState<Tin, Tout>
    {
        IState<Tin, Tout> NextState(Tin input);
        Move NextMove(Tin input);
    }
    public enum InputType
    {
        Left,
        Right,
        Forward
    }
    public record Move(int x, int y);
}
