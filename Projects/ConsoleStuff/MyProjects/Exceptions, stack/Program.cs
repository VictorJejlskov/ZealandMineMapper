using System;

namespace Exceptions__stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);

            while (true)
            {
                try
                {
                    string userInput = Convert.ToString(Console.ReadKey().KeyChar);
                    switch (userInput)
                    {
                        case "f":
                            stack.Push(1);
                            Console.WriteLine(stack);
                            break;
                        case "k":
                            stack.Pop();
                            Console.WriteLine(stack);
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
