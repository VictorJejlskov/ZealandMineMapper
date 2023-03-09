// See https://aka.ms/new-console-template for more information
using SnakeStateMachine;
using System.Reflection;

IStateMachine<InputType> sm = new StateMachineTable();
int minBoard = -10;
int maxBoard = 10;
int[] currentPos = new int[2] { 0, 0 };
Console.WriteLine("SNAAAAAAAAAAAAAAAAAAAKE!");
Console.WriteLine("Click any key to begin!");
print();
bool playing = true;
while (true)
{
    while (playing)
    {
        print();
    }
    Console.WriteLine("You lost you chonglehead");
    Console.WriteLine("Click any key to play again");
    currentPos = new int[2] { 0, 0 };
    playing = true;
}

void print()
{
    char c = Console.ReadKey().KeyChar;
    InputType input = InputType.Forward;
    switch (c)
    {
        case 'a':
            input = InputType.Left;
            break;
        case 'd':
            input = InputType.Right;
            break;
        case 'w':
            input = InputType.Forward;
            break;
    }
    Move nextMove = sm.NextInput(input);
    currentPos[0] += nextMove.x;
    currentPos[1] += nextMove.y;
    Console.Clear();
    for (int i = minBoard; i < maxBoard; i++)
    {
        for (int row = minBoard; row < maxBoard + 1; row++)
        {
            if (i == minBoard)
            {
                Console.Write("--");
                if (minBoard == currentPos[1]) playing = false;
            }
            else if (row == minBoard)
            {
                Console.Write("|");
                if (maxBoard == currentPos[0]) playing = false;
            }
            else if (row == maxBoard)
            {
                Console.Write("|");
                if (minBoard == currentPos[0]) playing = false;
            }
            else if (i == maxBoard-1)
            {
                Console.Write("--");
                if (maxBoard == currentPos[1]+1) playing = false;
            }
            else if (row == currentPos[0] && i == currentPos[1]) Console.Write(Head(sm.CurrentState()));
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("SNAAAAAAAAAAAAAAAAAAAKE!");
    Console.WriteLine("A / W / D");
    Console.WriteLine("X: " + currentPos[0] + ", Y: " + currentPos[1]);
    Console.WriteLine(sm.CurrentState());

}
string Head(string input)
{
    switch (input)
    {
        case "North":
            return "^ ";
        case "East":
            return "> ";
        case "South":
            return "V ";
        case "West":
            return "< ";
        default:
            return "^ ";
    }
}
