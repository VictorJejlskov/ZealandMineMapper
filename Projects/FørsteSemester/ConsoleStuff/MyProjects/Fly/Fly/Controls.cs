using System;
using System.Collections.Generic;
using System.Text;

namespace Fly
{
    class Controls
    {
        Fly myFly = new Fly("Airliner x3180", 0, 0, 0, 0);
        public void FlyingControls()
        {
            
            Console.Clear();
            Console.WriteLine(myFly.Instructions());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(myFly.FlyData());
            
            
            string userInput = Convert.ToString(Console.ReadKey().Key);
            if (userInput == Convert.ToString(ConsoleKey.Spacebar) && myFly.FirstTime == true)
            {
                myFly.LiftOff();
                myFly.IsFlying = true;
                myFly.FirstTime = false;
            }
            else if (userInput == Convert.ToString(ConsoleKey.K) && myFly.FirstTime == false && myFly.YSpeed != 0 && myFly.XSpeed != 0)
            {
                myFly.Stop();
            }
            else if (userInput == Convert.ToString(ConsoleKey.K) && myFly.FirstTime == false && myFly.YSpeed == 0 &&
                     myFly.XSpeed == 0)
            {
                myFly.LiftOff();
            }
            else if (userInput == Convert.ToString(ConsoleKey.A) && myFly.FirstTime == false)
            {
                myFly.Turn(-0.1, 0.1);
                myFly.Move();
            }
            else if (userInput == Convert.ToString(ConsoleKey.D) && myFly.FirstTime == false)
            {
                myFly.Turn(0.1, -0.1);
                myFly.Move();
            }
            else if (userInput == Convert.ToString(ConsoleKey.W) && myFly.FirstTime == false)
            {
                myFly.Accelerate();
                myFly.Move();
            }
            else if (userInput == Convert.ToString(ConsoleKey.S) && myFly.FirstTime == false)
            {
                myFly.Decelerate();
                myFly.Move();
            }
            else if (userInput == Convert.ToString(ConsoleKey.Spacebar) && myFly.FirstTime == false)
            {
                myFly.Move();
            }
        }
    }
}
