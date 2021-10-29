using System;
using System.Collections.Generic;
using System.Text;

namespace ISpeak
{
    class Philosopher : ISpeak
    {
        public string Speak()
        {
            return "Hello World!";
        }

        public string Think()
        {
            return "I think, therefore I am";
        }
    }
}
