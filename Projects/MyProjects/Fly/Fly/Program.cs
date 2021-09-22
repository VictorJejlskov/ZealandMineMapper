using System;
using System.Runtime.InteropServices;

namespace Fly
{
    class Program
    {

        static void Main(string[] args)
        {
            Controls myControls = new Controls();
            while (true)
            {
                myControls.FlyingControls();
            }



        }
    }
}
